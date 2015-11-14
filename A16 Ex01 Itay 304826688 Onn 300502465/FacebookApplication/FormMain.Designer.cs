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
            this.buttonGroupView = new System.Windows.Forms.Button();
            this.buttonLikeAnaylzer = new System.Windows.Forms.Button();
            this.textBoxStatusFromUser = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.checkBoxRemeberMe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_CoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_CoverPhoto
            // 
            this.picture_CoverPhoto.Image = global::FacebookApplication.Properties.Resources.CoverDefault;
            this.picture_CoverPhoto.Location = new System.Drawing.Point(-3, -1);
            this.picture_CoverPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picture_CoverPhoto.Name = "picture_CoverPhoto";
            this.picture_CoverPhoto.Size = new System.Drawing.Size(868, 320);
            this.picture_CoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_CoverPhoto.TabIndex = 0;
            this.picture_CoverPhoto.TabStop = false;
            // 
            // picture_ProfilePhoto
            // 
            this.picture_ProfilePhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_ProfilePhoto.Image = global::FacebookApplication.Properties.Resources.ProfileDefault;
            this.picture_ProfilePhoto.Location = new System.Drawing.Point(16, 15);
            this.picture_ProfilePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.picture_ProfilePhoto.Name = "picture_ProfilePhoto";
            this.picture_ProfilePhoto.Size = new System.Drawing.Size(125, 125);
            this.picture_ProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_ProfilePhoto.TabIndex = 1;
            this.picture_ProfilePhoto.TabStop = false;
            // 
            // buttonGroupView
            // 
            this.buttonGroupView.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGroupView.Location = new System.Drawing.Point(196, 49);
            this.buttonGroupView.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupView.Name = "buttonGroupView";
            this.buttonGroupView.Size = new System.Drawing.Size(125, 32);
            this.buttonGroupView.TabIndex = 2;
            this.buttonGroupView.Text = "Group View";
            this.buttonGroupView.UseVisualStyleBackColor = false;
            // 
            // buttonLikeAnaylzer
            // 
            this.buttonLikeAnaylzer.Location = new System.Drawing.Point(196, 89);
            this.buttonLikeAnaylzer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLikeAnaylzer.Name = "buttonLikeAnaylzer";
            this.buttonLikeAnaylzer.Size = new System.Drawing.Size(140, 32);
            this.buttonLikeAnaylzer.TabIndex = 3;
            this.buttonLikeAnaylzer.Text = "Like Analyzer";
            this.buttonLikeAnaylzer.UseVisualStyleBackColor = true;
            this.buttonLikeAnaylzer.Click += new System.EventHandler(this.buttonLikeAnalyzer_Click);
            // 
            // textBoxStatusFromUser
            // 
            this.textBoxStatusFromUser.Location = new System.Drawing.Point(211, 327);
            this.textBoxStatusFromUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatusFromUser.Name = "textBoxStatusFromUser";
            this.textBoxStatusFromUser.Size = new System.Drawing.Size(435, 22);
            this.textBoxStatusFromUser.TabIndex = 5;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(48, 327);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(100, 28);
            this.buttonPostStatus.TabIndex = 6;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 414);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Button 4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogin.Location = new System.Drawing.Point(196, 9);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 32);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(211, 359);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(435, 324);
            this.listBoxPosts.TabIndex = 9;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(93, 244);
            this.label_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(0, 17);
            this.label_FullName.TabIndex = 10;
            // 
            // checkBoxRemeberMe
            // 
            this.checkBoxRemeberMe.AutoSize = true;
            this.checkBoxRemeberMe.Location = new System.Drawing.Point(344, 16);
            this.checkBoxRemeberMe.Name = "checkBoxRemeberMe";
            this.checkBoxRemeberMe.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRemeberMe.TabIndex = 11;
            this.checkBoxRemeberMe.Text = "Remember me";
            this.checkBoxRemeberMe.UseVisualStyleBackColor = true;
            this.checkBoxRemeberMe.CheckedChanged += new System.EventHandler(this.checkBoxRemeberMe_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 805);
            this.Controls.Add(this.checkBoxRemeberMe);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxStatusFromUser);
            this.Controls.Add(this.buttonLikeAnaylzer);
            this.Controls.Add(this.buttonGroupView);
            this.Controls.Add(this.picture_ProfilePhoto);
            this.Controls.Add(this.picture_CoverPhoto);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button buttonGroupView;
        private System.Windows.Forms.Button buttonLikeAnaylzer;
        private System.Windows.Forms.TextBox textBoxStatusFromUser;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.CheckBox checkBoxRemeberMe;
    }
}

