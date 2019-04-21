using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using YoutubeSearch;

namespace YoutubeMassDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Quality {HIGH, LOW};

        string savePath = null;
        const int PAGE_SIZE = 20;
        const string BAD_SYMBOLS = "?/\\:*?'\"<>|";
        bool stop = false;
        Quality videoQuality = Quality.HIGH;

        public void setProgress(object sender, ProgressEventArgs e)
        {
            base.Invoke((Action)delegate { pBar.Value = (int)e.ProgressPercentage>=0? (int)e.ProgressPercentage : 0; });
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(savePath))
            {
                txtPage.Enabled = false;
                txtPageCount.Enabled = false;
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                btnFolder.Enabled = false;
                stop = false;

                StreamWriter sw = new StreamWriter("log.txt", false, System.Text.Encoding.Default);
                int i = 1;
                VideoSearch items = new VideoSearch();
                int startPage = !string.IsNullOrEmpty(txtPage.Text) ? int.Parse(txtPage.Text) : 1;
                int pageCount = !string.IsNullOrEmpty(txtPageCount.Text) ? int.Parse(txtPageCount.Text) : 1;
                for (int j = (startPage - 1) * PAGE_SIZE; j < items.SearchQuery(txtSearch.Text, startPage + pageCount - 1).Count; j++)
                {
                    if (stop)
                    {
                        sw.Close();
                        return;
                    }
                    var item = items.SearchQuery(txtSearch.Text, startPage + pageCount - 1)[j];

                    Console.WriteLine(item.Title);
                    try
                    {
                        IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(item.Url);
                        videos = DownloadUrlResolver.GetDownloadUrls(item.Url).Where(x => x.AudioBitrate>0 && x.Resolution>0 && x.VideoType==VideoType.Mp4);
                        VideoInfo video;
                        chooseQuality();
                        switch (videoQuality)
                        {
                            case Quality.HIGH:
                                video = videos.First(x => x.Resolution == videos.Max(r=>r.Resolution));
                                break;
                            case Quality.LOW:
                                video = videos.First(x => x.Resolution == videos.Min(r => r.Resolution));
                                break;
                            default:
                                video = videos.First(x => x.Resolution == videos.Max(r => r.Resolution));
                                break;
                        }
                        videos.First();
                        string title = video.Title;
                        for (int k = 0; k < title.Length; k++)
                        {
                            if (BAD_SYMBOLS.Contains(title[k]))
                            {
                                title = title.Replace(title[k], '_');
                            }
                        }
                        VideoDownloader download;
                        try
                        {
                            download = new VideoDownloader(video, Path.Combine(savePath + "\\", title + video.VideoExtension));
                        }
                        catch
                        {
                            download = new VideoDownloader(video, Path.Combine(savePath + "\\", txtSearch.Text + i + video.VideoExtension));
                        }

                        download.DownloadProgressChanged += new EventHandler<ProgressEventArgs>(setProgress);


                        lbFileName.Text = string.Format("Title: {0}", video.Title);

                        await Task.Run(() => download.Execute());

                        txtInfo.Text += "Video Page" + (j / PAGE_SIZE + 1) + "_" + i + " downloaded." + Environment.NewLine + "Title: " + video.Title + Environment.NewLine;
                        if (stop)
                        {
                            txtPage.Enabled = true;
                            txtPageCount.Enabled = true;
                            btnStop.Enabled = false;
                            btnStart.Enabled = true;
                            btnFolder.Enabled = true;
                            lbFileName.Text = "";
                            pBar.Value = 0;
                            MessageBox.Show("Canceled by user");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        sw.WriteLine(item.Title);
                        sw.WriteLine(item.Url);
                        sw.WriteLine(ex.Message);
                    }
                    i++;
                }
                MessageBox.Show("Done");
                sw.Close();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
            MessageBox.Show("Process will stop after downloading current video");
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                savePath = fbd.SelectedPath;
                txtPath.Text = savePath;
                btnStart.Enabled = true;
            }
        }

        private void chooseQuality()
        {
            if (rQuality1.Checked)
            {
                videoQuality = Quality.HIGH;
            }
            else
            {
                videoQuality = Quality.LOW;
            }
        }
        
    }
}
