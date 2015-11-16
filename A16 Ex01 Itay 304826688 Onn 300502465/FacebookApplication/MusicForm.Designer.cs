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
            this.profileImage = new System.Windows.Forms.PictureBox();
            this.ListBoxMusicans = new System.Windows.Forms.ListBox();
            this.musicianImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.profileName = new System.Windows.Forms.Label();
            this.buttonFetchMusic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicianImage)).BeginInit();
            this.SuspendLayout();
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
            // musicianImage
            // 
            this.musicianImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.musicianImage.Location = new System.Drawing.Point(335, 12);
            this.musicianImage.Name = "musicianImage";
            this.musicianImage.Size = new System.Drawing.Size(135, 131);
            this.musicianImage.TabIndex = 3;
            this.musicianImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
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
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 352);
            this.Controls.Add(this.buttonFetchMusic);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musicianImage);
            this.Controls.Add(this.ListBoxMusicans);
            this.Controls.Add(this.profileImage);
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicianImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profileImage;
        private System.Windows.Forms.ListBox ListBoxMusicans;
        private System.Windows.Forms.PictureBox musicianImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Button buttonFetchMusic;
    }
}