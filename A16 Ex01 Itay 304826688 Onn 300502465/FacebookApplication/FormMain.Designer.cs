namespace FacebookApplication
{
    partial class FormMain
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
            this.picture_CoverPhoto = new System.Windows.Forms.PictureBox();
            this.picture_ProfilePhoto = new System.Windows.Forms.PictureBox();
            this.button_GroupView = new System.Windows.Forms.Button();
            this.button_LikeAnaylzer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.listBox_Posts = new System.Windows.Forms.ListBox();
            this.label_FullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_CoverPhoto
            // 
            this.picture_CoverPhoto.Image = global::FacebookApplication.Properties.Resources.CoverDefault;
            this.picture_CoverPhoto.Location = new System.Drawing.Point(-2, -1);
            this.picture_CoverPhoto.Name = "picture_CoverPhoto";
            this.picture_CoverPhoto.Size = new System.Drawing.Size(654, 246);
            this.picture_CoverPhoto.TabIndex = 0;
            this.picture_CoverPhoto.TabStop = false;
            // 
            // picture_ProfilePhoto
            // 
            this.picture_ProfilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_ProfilePhoto.Image = global::FacebookApplication.Properties.Resources.ProfileDefault;
            this.picture_ProfilePhoto.Location = new System.Drawing.Point(12, 12);
            this.picture_ProfilePhoto.Name = "picture_ProfilePhoto";
            this.picture_ProfilePhoto.Size = new System.Drawing.Size(125, 125);
            this.picture_ProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_ProfilePhoto.TabIndex = 1;
            this.picture_ProfilePhoto.TabStop = false;
            // 
            // button_GroupView
            // 
            this.button_GroupView.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_GroupView.Location = new System.Drawing.Point(282, 12);
            this.button_GroupView.Name = "button_GroupView";
            this.button_GroupView.Size = new System.Drawing.Size(94, 26);
            this.button_GroupView.TabIndex = 2;
            this.button_GroupView.Text = "Group View";
            this.button_GroupView.UseVisualStyleBackColor = false;
            // 
            // button_LikeAnaylzer
            // 
            this.button_LikeAnaylzer.Location = new System.Drawing.Point(411, 12);
            this.button_LikeAnaylzer.Name = "button_LikeAnaylzer";
            this.button_LikeAnaylzer.Size = new System.Drawing.Size(105, 26);
            this.button_LikeAnaylzer.TabIndex = 3;
            this.button_LikeAnaylzer.Text = "Like Analyzer";
            this.button_LikeAnaylzer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Post";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Button 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Login.Location = new System.Drawing.Point(158, 12);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(91, 26);
            this.button_Login.TabIndex = 8;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBox_Posts
            // 
            this.listBox_Posts.FormattingEnabled = true;
            this.listBox_Posts.Location = new System.Drawing.Point(158, 292);
            this.listBox_Posts.Name = "listBox_Posts";
            this.listBox_Posts.Size = new System.Drawing.Size(327, 264);
            this.listBox_Posts.TabIndex = 9;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(70, 198);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(0, 15);
            this.label_FullName.TabIndex = 10;
            this.label_FullName.AutoSize = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 654);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.listBox_Posts);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_LikeAnaylzer);
            this.Controls.Add(this.button_GroupView);
            this.Controls.Add(this.picture_ProfilePhoto);
            this.Controls.Add(this.picture_CoverPhoto);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_CoverPhoto;
        private System.Windows.Forms.PictureBox picture_ProfilePhoto;
        private System.Windows.Forms.Button button_GroupView;
        private System.Windows.Forms.Button button_LikeAnaylzer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.ListBox listBox_Posts;
        private System.Windows.Forms.Label label_FullName;
    }
}

