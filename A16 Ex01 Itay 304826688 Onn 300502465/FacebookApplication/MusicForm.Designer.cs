namespace FacebookApplication
{
    partial class MusicForm
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
            this.ListBoxMusicans = new System.Windows.Forms.ListBox();
            this.buttonYouTubeChannel = new System.Windows.Forms.Button();
            this.profileName = new System.Windows.Forms.Label();
            this.buttonFetchMusic = new System.Windows.Forms.Button();
            this.ListBoxMusicianVideos = new System.Windows.Forms.ListBox();
            this.buttonPlayVideoOnYouTube = new System.Windows.Forms.Button();
            this.labelPageLikes = new System.Windows.Forms.Label();
            this.buttonLinkToPage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musicianImage = new System.Windows.Forms.PictureBox();
            this.profileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicianImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxMusicans
            // 
            this.ListBoxMusicans.BackColor = System.Drawing.Color.AliceBlue;
            this.ListBoxMusicans.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMusicans.FormattingEnabled = true;
            this.ListBoxMusicans.ItemHeight = 18;
            this.ListBoxMusicans.Location = new System.Drawing.Point(12, 118);
            this.ListBoxMusicans.Name = "ListBoxMusicans";
            this.ListBoxMusicans.Size = new System.Drawing.Size(259, 238);
            this.ListBoxMusicans.TabIndex = 2;
            this.ListBoxMusicans.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusicans_SelectedIndexChanged);
            // 
            // buttonYouTubeChannel
            // 
            this.buttonYouTubeChannel.BackColor = System.Drawing.Color.Crimson;
            this.buttonYouTubeChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYouTubeChannel.ForeColor = System.Drawing.Color.White;
            this.buttonYouTubeChannel.Location = new System.Drawing.Point(313, 298);
            this.buttonYouTubeChannel.Name = "buttonYouTubeChannel";
            this.buttonYouTubeChannel.Size = new System.Drawing.Size(135, 58);
            this.buttonYouTubeChannel.TabIndex = 5;
            this.buttonYouTubeChannel.Text = "YouTube Channel";
            this.buttonYouTubeChannel.UseVisualStyleBackColor = false;
            this.buttonYouTubeChannel.Click += new System.EventHandler(this.buttonYouTubeChannel_Click);
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(118, 24);
            this.profileName.Name = "profileName";
            this.profileName.Padding = new System.Windows.Forms.Padding(2);
            this.profileName.Size = new System.Drawing.Size(160, 20);
            this.profileName.TabIndex = 8;
            this.profileName.Text = "Facebook UserName";
            // 
            // buttonFetchMusic
            // 
            this.buttonFetchMusic.BackColor = System.Drawing.Color.LightGreen;
            this.buttonFetchMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMusic.Location = new System.Drawing.Point(118, 72);
            this.buttonFetchMusic.Name = "buttonFetchMusic";
            this.buttonFetchMusic.Size = new System.Drawing.Size(153, 40);
            this.buttonFetchMusic.TabIndex = 9;
            this.buttonFetchMusic.Text = "Fetch Music";
            this.buttonFetchMusic.UseVisualStyleBackColor = false;
            this.buttonFetchMusic.Click += new System.EventHandler(this.buttonFetchMusic_Click);
            // 
            // ListBoxMusicianVideos
            // 
            this.ListBoxMusicianVideos.BackColor = System.Drawing.Color.AliceBlue;
            this.ListBoxMusicianVideos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMusicianVideos.FormattingEnabled = true;
            this.ListBoxMusicianVideos.ItemHeight = 18;
            this.ListBoxMusicianVideos.Location = new System.Drawing.Point(483, 118);
            this.ListBoxMusicianVideos.MaximumSize = new System.Drawing.Size(500, 238);
            this.ListBoxMusicianVideos.MinimumSize = new System.Drawing.Size(383, 238);
            this.ListBoxMusicianVideos.Name = "ListBoxMusicianVideos";
            this.ListBoxMusicianVideos.Size = new System.Drawing.Size(439, 238);
            this.ListBoxMusicianVideos.TabIndex = 10;
            this.ListBoxMusicianVideos.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusicianVideos_SelectedIndexChanged);
            // 
            // buttonPlayVideoOnYouTube
            // 
            this.buttonPlayVideoOnYouTube.BackColor = System.Drawing.Color.LightGreen;
            this.buttonPlayVideoOnYouTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayVideoOnYouTube.Location = new System.Drawing.Point(483, 72);
            this.buttonPlayVideoOnYouTube.Name = "buttonPlayVideoOnYouTube";
            this.buttonPlayVideoOnYouTube.Size = new System.Drawing.Size(153, 40);
            this.buttonPlayVideoOnYouTube.TabIndex = 11;
            this.buttonPlayVideoOnYouTube.Text = "Play Video";
            this.buttonPlayVideoOnYouTube.UseVisualStyleBackColor = false;
            this.buttonPlayVideoOnYouTube.Click += new System.EventHandler(this.buttonPlayVideoOnYouTube_Click);
            // 
            // labelPageLikes
            // 
            this.labelPageLikes.AutoSize = true;
            this.labelPageLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageLikes.Location = new System.Drawing.Point(331, 158);
            this.labelPageLikes.Margin = new System.Windows.Forms.Padding(3);
            this.labelPageLikes.MinimumSize = new System.Drawing.Size(3, 3);
            this.labelPageLikes.Name = "labelPageLikes";
            this.labelPageLikes.Padding = new System.Windows.Forms.Padding(2);
            this.labelPageLikes.Size = new System.Drawing.Size(101, 24);
            this.labelPageLikes.TabIndex = 12;
            this.labelPageLikes.Text = "PageLikes:";
            this.labelPageLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPageLikes.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLinkToPage
            // 
            this.buttonLinkToPage.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonLinkToPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkToPage.ForeColor = System.Drawing.Color.White;
            this.buttonLinkToPage.Location = new System.Drawing.Point(313, 236);
            this.buttonLinkToPage.Name = "buttonLinkToPage";
            this.buttonLinkToPage.Size = new System.Drawing.Size(135, 58);
            this.buttonLinkToPage.TabIndex = 13;
            this.buttonLinkToPage.Text = "Facebook Page";
            this.buttonLinkToPage.UseVisualStyleBackColor = false;
            this.buttonLinkToPage.Click += new System.EventHandler(this.buttonLinkToPage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FacebookApplication.Properties.Resources.youtube_logo;
            this.pictureBox2.Location = new System.Drawing.Point(766, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FacebookApplication.Properties.Resources.facebook_logo;
            this.pictureBox1.Location = new System.Drawing.Point(848, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // musicianImage
            // 
            this.musicianImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.musicianImage.Location = new System.Drawing.Point(313, 12);
            this.musicianImage.Name = "musicianImage";
            this.musicianImage.Size = new System.Drawing.Size(135, 131);
            this.musicianImage.TabIndex = 3;
            this.musicianImage.TabStop = false;
            // 
            // profileImage
            // 
            this.profileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileImage.Location = new System.Drawing.Point(12, 12);
            this.profileImage.MinimumSize = new System.Drawing.Size(100, 100);
            this.profileImage.Name = "profileImage";
            this.profileImage.Padding = new System.Windows.Forms.Padding(2);
            this.profileImage.Size = new System.Drawing.Size(100, 100);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            this.profileImage.Click += new System.EventHandler(this.profileImage_Click);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 373);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLinkToPage);
            this.Controls.Add(this.labelPageLikes);
            this.Controls.Add(this.buttonPlayVideoOnYouTube);
            this.Controls.Add(this.ListBoxMusicianVideos);
            this.Controls.Add(this.buttonFetchMusic);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.buttonYouTubeChannel);
            this.Controls.Add(this.musicianImage);
            this.Controls.Add(this.ListBoxMusicans);
            this.Controls.Add(this.profileImage);
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicianImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.ListBox ListBoxMusicans;
        private System.Windows.Forms.PictureBox musicianImage;
        private System.Windows.Forms.Button buttonYouTubeChannel;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Button buttonFetchMusic;
        private System.Windows.Forms.ListBox ListBoxMusicianVideos;
        private System.Windows.Forms.Button buttonPlayVideoOnYouTube;
        private System.Windows.Forms.Label labelPageLikes;
        private System.Windows.Forms.Button buttonLinkToPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}