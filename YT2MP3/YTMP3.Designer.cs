namespace YT2MP3
{
    partial class YTMP3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTMP3));
            this.URLS = new System.Windows.Forms.ListBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.a_button = new System.Windows.Forms.Button();
            this.r_button = new System.Windows.Forms.Button();
            this.d_button = new System.Windows.Forms.Button();
            this.u_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.TextBox();
            this.selectPath = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tabs = new System.Windows.Forms.TabControl();
            this.Download = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TabPage();
            this.tosearch = new System.Windows.Forms.TextBox();
            this.s_button = new System.Windows.Forms.Button();
            this.risultati = new System.Windows.Forms.ListBox();
            this.c_butt = new System.Windows.Forms.Button();
            this.add_butt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabs.SuspendLayout();
            this.Download.SuspendLayout();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLS
            // 
            this.URLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.URLS.FormattingEnabled = true;
            this.URLS.Location = new System.Drawing.Point(6, 6);
            this.URLS.Name = "URLS";
            this.URLS.Size = new System.Drawing.Size(426, 368);
            this.URLS.TabIndex = 0;
            // 
            // URL
            // 
            this.URL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.URL.Location = new System.Drawing.Point(438, 6);
            this.URL.Multiline = true;
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(298, 141);
            this.URL.TabIndex = 1;
            this.URL.Text = "Paste URL here";
            this.URL.Click += new System.EventHandler(this.eraseContent);
            // 
            // a_button
            // 
            this.a_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.a_button.Location = new System.Drawing.Point(439, 155);
            this.a_button.Name = "a_button";
            this.a_button.Size = new System.Drawing.Size(297, 33);
            this.a_button.TabIndex = 2;
            this.a_button.Text = "ADD";
            this.a_button.UseVisualStyleBackColor = true;
            this.a_button.Click += new System.EventHandler(this.a_button_Click);
            // 
            // r_button
            // 
            this.r_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.r_button.Location = new System.Drawing.Point(440, 194);
            this.r_button.Name = "r_button";
            this.r_button.Size = new System.Drawing.Size(297, 33);
            this.r_button.TabIndex = 3;
            this.r_button.Text = "REMOVE";
            this.r_button.UseVisualStyleBackColor = true;
            this.r_button.Click += new System.EventHandler(this.r_button_Click);
            // 
            // d_button
            // 
            this.d_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.d_button.Location = new System.Drawing.Point(438, 331);
            this.d_button.Name = "d_button";
            this.d_button.Size = new System.Drawing.Size(297, 45);
            this.d_button.TabIndex = 4;
            this.d_button.Text = "DOWLOAD";
            this.d_button.UseVisualStyleBackColor = true;
            this.d_button.Click += new System.EventHandler(this.d_button_Click);
            // 
            // u_button
            // 
            this.u_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.u_button.Location = new System.Drawing.Point(438, 384);
            this.u_button.MaximumSize = new System.Drawing.Size(297, 20);
            this.u_button.MinimumSize = new System.Drawing.Size(297, 20);
            this.u_button.Name = "u_button";
            this.u_button.Size = new System.Drawing.Size(297, 20);
            this.u_button.TabIndex = 6;
            this.u_button.Text = "CHECK FOR UPDATES";
            this.u_button.UseVisualStyleBackColor = true;
            this.u_button.Click += new System.EventHandler(this.u_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Save To_";
            // 
            // directory
            // 
            this.directory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.directory.Location = new System.Drawing.Point(500, 255);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(204, 20);
            this.directory.TabIndex = 8;
            // 
            // selectPath
            // 
            this.selectPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectPath.Location = new System.Drawing.Point(708, 255);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(27, 20);
            this.selectPath.TabIndex = 9;
            this.selectPath.Text = "...";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 391);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(250, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "by BurningHam, Copyright 2016, GNU v3.0 License";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progress
            // 
            this.progress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progress.Location = new System.Drawing.Point(438, 302);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(297, 23);
            this.progress.TabIndex = 19;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.Download);
            this.tabs.Controls.Add(this.Search);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(755, 439);
            this.tabs.TabIndex = 20;
            // 
            // Download
            // 
            this.Download.Controls.Add(this.URLS);
            this.Download.Controls.Add(this.progress);
            this.Download.Controls.Add(this.URL);
            this.Download.Controls.Add(this.linkLabel1);
            this.Download.Controls.Add(this.a_button);
            this.Download.Controls.Add(this.selectPath);
            this.Download.Controls.Add(this.r_button);
            this.Download.Controls.Add(this.directory);
            this.Download.Controls.Add(this.d_button);
            this.Download.Controls.Add(this.label1);
            this.Download.Controls.Add(this.u_button);
            this.Download.Location = new System.Drawing.Point(4, 22);
            this.Download.Name = "Download";
            this.Download.Padding = new System.Windows.Forms.Padding(3);
            this.Download.Size = new System.Drawing.Size(747, 413);
            this.Download.TabIndex = 0;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.linkLabel2);
            this.Search.Controls.Add(this.panel1);
            this.Search.Controls.Add(this.add_butt);
            this.Search.Controls.Add(this.c_butt);
            this.Search.Controls.Add(this.risultati);
            this.Search.Controls.Add(this.s_button);
            this.Search.Controls.Add(this.tosearch);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(747, 413);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // tosearch
            // 
            this.tosearch.Location = new System.Drawing.Point(9, 8);
            this.tosearch.Name = "tosearch";
            this.tosearch.Size = new System.Drawing.Size(649, 20);
            this.tosearch.TabIndex = 0;
            this.tosearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterpressed);
            // 
            // s_button
            // 
            this.s_button.Location = new System.Drawing.Point(664, 7);
            this.s_button.Name = "s_button";
            this.s_button.Size = new System.Drawing.Size(75, 23);
            this.s_button.TabIndex = 1;
            this.s_button.Text = "Search";
            this.s_button.UseVisualStyleBackColor = true;
            this.s_button.Click += new System.EventHandler(this.s_button_Click);
            // 
            // risultati
            // 
            this.risultati.FormattingEnabled = true;
            this.risultati.Location = new System.Drawing.Point(9, 35);
            this.risultati.Name = "risultati";
            this.risultati.Size = new System.Drawing.Size(396, 368);
            this.risultati.TabIndex = 2;
            this.risultati.SelectedIndexChanged += new System.EventHandler(this.mostrathumbnail);
            this.risultati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mouseDoubleClick);
            // 
            // c_butt
            // 
            this.c_butt.Location = new System.Drawing.Point(416, 351);
            this.c_butt.Name = "c_butt";
            this.c_butt.Size = new System.Drawing.Size(323, 23);
            this.c_butt.TabIndex = 3;
            this.c_butt.Text = "Clear";
            this.c_butt.UseVisualStyleBackColor = true;
            this.c_butt.Click += new System.EventHandler(this.c_butt_Click);
            // 
            // add_butt
            // 
            this.add_butt.Location = new System.Drawing.Point(416, 322);
            this.add_butt.Name = "add_butt";
            this.add_butt.Size = new System.Drawing.Size(323, 23);
            this.add_butt.TabIndex = 4;
            this.add_butt.Text = "Add to List";
            this.add_butt.UseVisualStyleBackColor = true;
            this.add_butt.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(416, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 262);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(524, 390);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Search idea by cttynul";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // YTMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 439);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YTMP3";
            this.Text = "YT_2_MP3";
            this.tabs.ResumeLayout(false);
            this.Download.ResumeLayout(false);
            this.Download.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox URLS;
        public System.Windows.Forms.TextBox URL;
        public System.Windows.Forms.Button a_button;
        public System.Windows.Forms.Button r_button;
        public System.Windows.Forms.Button d_button;
        public System.Windows.Forms.Button u_button;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox directory;
        public System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage Download;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_butt;
        private System.Windows.Forms.Button c_butt;
        private System.Windows.Forms.ListBox risultati;
        private System.Windows.Forms.Button s_button;
        private System.Windows.Forms.TextBox tosearch;
    }
}

