﻿namespace FacebookApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
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
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicianImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxMusicans
            // 
            this.ListBoxMusicans.BackColor = System.Drawing.Color.AliceBlue;
            this.ListBoxMusicans.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxMusicans.FormattingEnabled = true;
            this.ListBoxMusicans.ItemHeight = 23;
            this.ListBoxMusicans.Location = new System.Drawing.Point(16, 145);
            this.ListBoxMusicans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxMusicans.Name = "ListBoxMusicans";
            this.ListBoxMusicans.Size = new System.Drawing.Size(344, 280);
            this.ListBoxMusicans.TabIndex = 2;
            this.ListBoxMusicans.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusicans_SelectedIndexChanged);
            // 
            // buttonYouTubeChannel
            // 
            this.buttonYouTubeChannel.BackColor = System.Drawing.Color.Crimson;
            this.buttonYouTubeChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYouTubeChannel.ForeColor = System.Drawing.Color.White;
            this.buttonYouTubeChannel.Location = new System.Drawing.Point(964, 4);
            this.buttonYouTubeChannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonYouTubeChannel.Name = "buttonYouTubeChannel";
            this.buttonYouTubeChannel.Size = new System.Drawing.Size(180, 71);
            this.buttonYouTubeChannel.TabIndex = 5;
            this.buttonYouTubeChannel.Text = "YouTube Channel";
            this.buttonYouTubeChannel.UseVisualStyleBackColor = false;
            this.buttonYouTubeChannel.Click += new System.EventHandler(this.buttonYouTubeChannel_Click);
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.Location = new System.Drawing.Point(157, 30);
            this.profileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profileName.Name = "profileName";
            this.profileName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileName.Size = new System.Drawing.Size(189, 24);
            this.profileName.TabIndex = 8;
            this.profileName.Text = "Facebook UserName";
            // 
            // buttonFetchMusic
            // 
            this.buttonFetchMusic.BackColor = System.Drawing.Color.LightGreen;
            this.buttonFetchMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMusic.Location = new System.Drawing.Point(157, 89);
            this.buttonFetchMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFetchMusic.Name = "buttonFetchMusic";
            this.buttonFetchMusic.Size = new System.Drawing.Size(204, 49);
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
            this.ListBoxMusicianVideos.HorizontalScrollbar = true;
            this.ListBoxMusicianVideos.ItemHeight = 23;
            this.ListBoxMusicianVideos.Location = new System.Drawing.Point(868, 145);
            this.ListBoxMusicianVideos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBoxMusicianVideos.MaximumSize = new System.Drawing.Size(665, 292);
            this.ListBoxMusicianVideos.MinimumSize = new System.Drawing.Size(509, 292);
            this.ListBoxMusicianVideos.Name = "ListBoxMusicianVideos";
            this.ListBoxMusicianVideos.Size = new System.Drawing.Size(665, 280);
            this.ListBoxMusicianVideos.TabIndex = 10;
            this.ListBoxMusicianVideos.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusicianVideos_SelectedIndexChanged);
            // 
            // buttonPlayVideoOnYouTube
            // 
            this.buttonPlayVideoOnYouTube.BackColor = System.Drawing.Color.Gold;
            this.buttonPlayVideoOnYouTube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayVideoOnYouTube.ForeColor = System.Drawing.Color.White;
            this.buttonPlayVideoOnYouTube.Location = new System.Drawing.Point(868, 71);
            this.buttonPlayVideoOnYouTube.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlayVideoOnYouTube.Name = "buttonPlayVideoOnYouTube";
            this.buttonPlayVideoOnYouTube.Size = new System.Drawing.Size(180, 71);
            this.buttonPlayVideoOnYouTube.TabIndex = 11;
            this.buttonPlayVideoOnYouTube.Text = "Play In Browser";
            this.buttonPlayVideoOnYouTube.UseVisualStyleBackColor = false;
            this.buttonPlayVideoOnYouTube.Click += new System.EventHandler(this.buttonPlayVideoOnYouTube_Click);
            // 
            // labelPageLikes
            // 
            this.labelPageLikes.AutoSize = true;
            this.labelPageLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageLikes.Location = new System.Drawing.Point(656, 15);
            this.labelPageLikes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelPageLikes.MinimumSize = new System.Drawing.Size(4, 4);
            this.labelPageLikes.Name = "labelPageLikes";
            this.labelPageLikes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelPageLikes.Size = new System.Drawing.Size(126, 29);
            this.labelPageLikes.TabIndex = 12;
            this.labelPageLikes.Text = "PageLikes:";
            this.labelPageLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLinkToPage
            // 
            this.buttonLinkToPage.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonLinkToPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkToPage.ForeColor = System.Drawing.Color.White;
            this.buttonLinkToPage.Location = new System.Drawing.Point(1056, 71);
            this.buttonLinkToPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLinkToPage.Name = "buttonLinkToPage";
            this.buttonLinkToPage.Size = new System.Drawing.Size(180, 71);
            this.buttonLinkToPage.TabIndex = 13;
            this.buttonLinkToPage.Text = "Facebook Page";
            this.buttonLinkToPage.UseVisualStyleBackColor = false;
            this.buttonLinkToPage.Click += new System.EventHandler(this.buttonLinkToPage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FacebookApplication.Properties.Resources.youtube_logo;
            this.pictureBox2.Location = new System.Drawing.Point(1340, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FacebookApplication.Properties.Resources.facebook_logo;
            this.pictureBox1.Location = new System.Drawing.Point(1449, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // musicianImage
            // 
            this.musicianImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.musicianImage.Location = new System.Drawing.Point(449, 15);
            this.musicianImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicianImage.Name = "musicianImage";
            this.musicianImage.Size = new System.Drawing.Size(160, 122);
            this.musicianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.musicianImage.TabIndex = 3;
            this.musicianImage.TabStop = false;
            // 
            // profileImage
            // 
            this.profileImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileImage.Location = new System.Drawing.Point(16, 15);
            this.profileImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profileImage.MinimumSize = new System.Drawing.Size(132, 122);
            this.profileImage.Name = "profileImage";
            this.profileImage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileImage.Size = new System.Drawing.Size(132, 122);
            this.profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileImage.TabIndex = 0;
            this.profileImage.TabStop = false;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(273, 118);
            this.axShockwaveFlash1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(240, 240);
            this.axShockwaveFlash1.TabIndex = 16;
            this.axShockwaveFlash1.Enter += new System.EventHandler(this.axShockwaveFlash1_Enter);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 452);
            this.Controls.Add(this.axShockwaveFlash1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicianImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
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
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}