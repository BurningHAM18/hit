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
            this.label1 = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.TextBox();
            this.selectPath = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.tabs = new System.Windows.Forms.TabControl();
            this.Download = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player1 = new AxAXVLC.AxVLCPlugin2();
            this.risultati = new System.Windows.Forms.ListBox();
            this.s_button = new System.Windows.Forms.Button();
            this.tosearch = new System.Windows.Forms.TextBox();
            this.Player = new System.Windows.Forms.TabPage();
            this.repeat = new System.Windows.Forms.Panel();
            this.next = new System.Windows.Forms.Panel();
            this.shuffle = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Panel();
            this.previous = new System.Windows.Forms.Panel();
            this.playingsong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.songs = new System.Windows.Forms.ListBox();
            this.selectSongsPath = new System.Windows.Forms.Button();
            this.songsPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.player2 = new AxAXVLC.AxVLCPlugin2();
            this.refresh = new System.Windows.Forms.Panel();
            this.tabs.SuspendLayout();
            this.Download.SuspendLayout();
            this.Search.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
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
            this.linkLabel1.Location = new System.Drawing.Point(462, 352);
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
            this.progress.Location = new System.Drawing.Point(439, 307);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(297, 23);
            this.progress.TabIndex = 19;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.Download);
            this.tabs.Controls.Add(this.Search);
            this.tabs.Controls.Add(this.Player);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(755, 407);
            this.tabs.TabIndex = 20;
            // 
            // Download
            // 
            this.Download.Controls.Add(this.panel3);
            this.Download.Controls.Add(this.panel4);
            this.Download.Controls.Add(this.panel5);
            this.Download.Controls.Add(this.panel2);
            this.Download.Controls.Add(this.URLS);
            this.Download.Controls.Add(this.progress);
            this.Download.Controls.Add(this.URL);
            this.Download.Controls.Add(this.linkLabel1);
            this.Download.Controls.Add(this.selectPath);
            this.Download.Controls.Add(this.directory);
            this.Download.Controls.Add(this.label1);
            this.Download.Location = new System.Drawing.Point(4, 22);
            this.Download.Name = "Download";
            this.Download.Padding = new System.Windows.Forms.Padding(3);
            this.Download.Size = new System.Drawing.Size(747, 381);
            this.Download.TabIndex = 0;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AccessibleDescription = "Remove from list";
            this.panel3.BackgroundImage = global::_hit_.Properties.Resources.minus;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(515, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 51);
            this.panel3.TabIndex = 17;
            this.panel3.Click += new System.EventHandler(this.r_button_Click);
            // 
            // panel4
            // 
            this.panel4.AccessibleDescription = "Download";
            this.panel4.BackgroundImage = global::_hit_.Properties.Resources.download;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(588, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 51);
            this.panel4.TabIndex = 17;
            this.panel4.Click += new System.EventHandler(this.d_button_Click);
            // 
            // panel5
            // 
            this.panel5.AccessibleDescription = "Check for updates";
            this.panel5.BackgroundImage = global::_hit_.Properties.Resources.worldwide;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(661, 156);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(72, 51);
            this.panel5.TabIndex = 17;
            this.panel5.Click += new System.EventHandler(this.u_button_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "Add to list";
            this.panel2.BackgroundImage = global::_hit_.Properties.Resources.plus;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(442, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 51);
            this.panel2.TabIndex = 20;
            this.panel2.Click += new System.EventHandler(this.a_button_Click);
            // 
            // Search
            // 
            this.Search.Controls.Add(this.panel7);
            this.Search.Controls.Add(this.panel6);
            this.Search.Controls.Add(this.linkLabel2);
            this.Search.Controls.Add(this.panel1);
            this.Search.Controls.Add(this.risultati);
            this.Search.Controls.Add(this.s_button);
            this.Search.Controls.Add(this.tosearch);
            this.Search.Location = new System.Drawing.Point(4, 22);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(747, 381);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.AccessibleDescription = "Clear search results";
            this.panel7.BackgroundImage = global::_hit_.Properties.Resources.error;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(595, 304);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(72, 51);
            this.panel7.TabIndex = 18;
            this.panel7.Click += new System.EventHandler(this.c_butt_Click);
            // 
            // panel6
            // 
            this.panel6.AccessibleDescription = "Add to list";
            this.panel6.AccessibleName = "Add to list";
            this.panel6.BackgroundImage = global::_hit_.Properties.Resources.plus;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(480, 304);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(72, 51);
            this.panel6.TabIndex = 18;
            this.panel6.Click += new System.EventHandler(this.add_butt_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(524, 361);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Search idea by cttynul";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.player1);
            this.panel1.Location = new System.Drawing.Point(416, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 262);
            this.panel1.TabIndex = 5;
            // 
            // player1
            // 
            this.player1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player1.Enabled = true;
            this.player1.Location = new System.Drawing.Point(0, 0);
            this.player1.Name = "player1";
            this.player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player1.OcxState")));
            this.player1.Size = new System.Drawing.Size(321, 260);
            this.player1.TabIndex = 0;
            // 
            // risultati
            // 
            this.risultati.FormattingEnabled = true;
            this.risultati.Location = new System.Drawing.Point(9, 35);
            this.risultati.Name = "risultati";
            this.risultati.Size = new System.Drawing.Size(396, 342);
            this.risultati.TabIndex = 2;
            this.risultati.SelectedIndexChanged += new System.EventHandler(this.mostrathumbnail);
            this.risultati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mouseDoubleClick);
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
            // tosearch
            // 
            this.tosearch.Location = new System.Drawing.Point(9, 8);
            this.tosearch.Name = "tosearch";
            this.tosearch.Size = new System.Drawing.Size(649, 20);
            this.tosearch.TabIndex = 0;
            this.tosearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterpressed);
            // 
            // Player
            // 
            this.Player.Controls.Add(this.refresh);
            this.Player.Controls.Add(this.repeat);
            this.Player.Controls.Add(this.next);
            this.Player.Controls.Add(this.shuffle);
            this.Player.Controls.Add(this.pause);
            this.Player.Controls.Add(this.play);
            this.Player.Controls.Add(this.previous);
            this.Player.Controls.Add(this.playingsong);
            this.Player.Controls.Add(this.label3);
            this.Player.Controls.Add(this.songs);
            this.Player.Controls.Add(this.selectSongsPath);
            this.Player.Controls.Add(this.songsPath);
            this.Player.Controls.Add(this.label2);
            this.Player.Controls.Add(this.player2);
            this.Player.Location = new System.Drawing.Point(4, 22);
            this.Player.Name = "Player";
            this.Player.Padding = new System.Windows.Forms.Padding(3);
            this.Player.Size = new System.Drawing.Size(747, 381);
            this.Player.TabIndex = 2;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = true;
            // 
            // repeat
            // 
            this.repeat.BackgroundImage = global::_hit_.Properties.Resources.repeat;
            this.repeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repeat.Enabled = false;
            this.repeat.Location = new System.Drawing.Point(669, 101);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(72, 51);
            this.repeat.TabIndex = 20;
            this.repeat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.repeat_Paint);
            // 
            // next
            // 
            this.next.BackgroundImage = global::_hit_.Properties.Resources.next;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.Enabled = false;
            this.next.Location = new System.Drawing.Point(669, 44);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(72, 51);
            this.next.TabIndex = 19;
            this.next.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nextSong);
            // 
            // shuffle
            // 
            this.shuffle.BackgroundImage = global::_hit_.Properties.Resources.shuffle;
            this.shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shuffle.Enabled = false;
            this.shuffle.Location = new System.Drawing.Point(435, 101);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(72, 51);
            this.shuffle.TabIndex = 19;
            this.shuffle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.shuffle_Paint);
            // 
            // pause
            // 
            this.pause.BackgroundImage = global::_hit_.Properties.Resources.pause;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pause.Enabled = false;
            this.pause.Location = new System.Drawing.Point(591, 44);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(72, 51);
            this.pause.TabIndex = 18;
            this.pause.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pauseSong);
            // 
            // play
            // 
            this.play.BackgroundImage = global::_hit_.Properties.Resources.play_button;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.play.Enabled = false;
            this.play.Location = new System.Drawing.Point(513, 44);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(72, 51);
            this.play.TabIndex = 17;
            this.play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playSong);
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::_hit_.Properties.Resources.back;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previous.Enabled = false;
            this.previous.Location = new System.Drawing.Point(435, 44);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(72, 51);
            this.previous.TabIndex = 16;
            this.previous.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reloadSong);
            this.previous.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.previousSong);
            // 
            // playingsong
            // 
            this.playingsong.AutoSize = true;
            this.playingsong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingsong.Location = new System.Drawing.Point(451, 10);
            this.playingsong.Name = "playingsong";
            this.playingsong.Size = new System.Drawing.Size(43, 13);
            this.playingsong.TabIndex = 15;
            this.playingsong.Text = "(none)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NOW PLAYING:";
            // 
            // songs
            // 
            this.songs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.songs.FormattingEnabled = true;
            this.songs.Location = new System.Drawing.Point(1, 44);
            this.songs.Name = "songs";
            this.songs.Size = new System.Drawing.Size(426, 329);
            this.songs.TabIndex = 13;
            this.songs.DoubleClick += new System.EventHandler(this.playSong);
            // 
            // selectSongsPath
            // 
            this.selectSongsPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectSongsPath.Location = new System.Drawing.Point(315, 6);
            this.selectSongsPath.Name = "selectSongsPath";
            this.selectSongsPath.Size = new System.Drawing.Size(27, 20);
            this.selectSongsPath.TabIndex = 12;
            this.selectSongsPath.Text = "...";
            this.selectSongsPath.UseVisualStyleBackColor = true;
            this.selectSongsPath.Click += new System.EventHandler(this.selectSongsPath_Click);
            // 
            // songsPath
            // 
            this.songsPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.songsPath.Location = new System.Drawing.Point(107, 6);
            this.songsPath.Name = "songsPath";
            this.songsPath.Size = new System.Drawing.Size(204, 20);
            this.songsPath.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Songs Path_";
            // 
            // player2
            // 
            this.player2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.player2.Enabled = true;
            this.player2.Location = new System.Drawing.Point(435, 345);
            this.player2.Name = "player2";
            this.player2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player2.OcxState")));
            this.player2.Size = new System.Drawing.Size(309, 33);
            this.player2.TabIndex = 0;
            this.player2.TabStop = false;
            this.player2.Visible = false;
            this.player2.MediaPlayerEndReached += new System.EventHandler(this.SongEnded);
            this.player2.MediaPlayerStopped += new System.EventHandler(this.resetLablePlaying);
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::_hit_.Properties.Resources.binoculars;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Location = new System.Drawing.Point(3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(29, 25);
            this.refresh.TabIndex = 18;
            this.refresh.Click += new System.EventHandler(this.refreshSongs);
            // 
            // YTMP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 407);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YTMP3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_hit_";
            this.tabs.ResumeLayout(false);
            this.Download.ResumeLayout(false);
            this.Download.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.Player.ResumeLayout(false);
            this.Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox URLS;
        public System.Windows.Forms.TextBox URL;
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
        private System.Windows.Forms.ListBox risultati;
        private System.Windows.Forms.Button s_button;
        private System.Windows.Forms.TextBox tosearch;
        private System.Windows.Forms.TabPage Player;
        private AxAXVLC.AxVLCPlugin2 player2;
        private AxAXVLC.AxVLCPlugin2 player1;
        public System.Windows.Forms.Button selectSongsPath;
        public System.Windows.Forms.TextBox songsPath;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox songs;
        private System.Windows.Forms.Label playingsong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel next;
        private System.Windows.Forms.Panel pause;
        private System.Windows.Forms.Panel play;
        private System.Windows.Forms.Panel previous;
        private System.Windows.Forms.Panel repeat;
        private System.Windows.Forms.Panel shuffle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel refresh;
    }
}

