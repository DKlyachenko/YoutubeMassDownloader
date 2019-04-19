namespace YoutubeMassDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbFileName = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.lbPageCount = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lbPage = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Search:";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(135, 164);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 23);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(359, 125);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(89, 23);
            this.btnFolder.TabIndex = 27;
            this.btnFolder.Text = "folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(26, 125);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(327, 23);
            this.txtPath.TabIndex = 26;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(23, 209);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(0, 13);
            this.lbFileName.TabIndex = 25;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(26, 236);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(422, 23);
            this.pBar.TabIndex = 24;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(26, 269);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(422, 107);
            this.txtInfo.TabIndex = 23;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(238, 75);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(30, 20);
            this.txtPageCount.TabIndex = 21;
            this.txtPageCount.Text = "1";
            // 
            // lbPageCount
            // 
            this.lbPageCount.AutoSize = true;
            this.lbPageCount.Location = new System.Drawing.Point(159, 78);
            this.lbPageCount.Name = "lbPageCount";
            this.lbPageCount.Size = new System.Drawing.Size(65, 13);
            this.lbPageCount.TabIndex = 19;
            this.lbPageCount.Text = "Page count:";
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(102, 75);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(30, 20);
            this.txtPage.TabIndex = 22;
            this.txtPage.Text = "1";
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(23, 78);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(58, 13);
            this.lbPage.TabIndex = 20;
            this.lbPage.Text = "Page start:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(422, 20);
            this.txtSearch.TabIndex = 18;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(26, 164);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.lbPageCount);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label lbPageCount;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnStart;
    }
}

