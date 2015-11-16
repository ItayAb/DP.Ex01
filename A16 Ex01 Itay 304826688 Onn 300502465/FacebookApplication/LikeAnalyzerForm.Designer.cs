namespace FacebookApplication
{
    partial class LikeAnalyzerForm
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
            this.listBoxDescendingLikeFriends = new System.Windows.Forms.ListBox();
            this.PictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBoxRecentPost = new System.Windows.Forms.ListBox();
            this.buttonLikeBack = new System.Windows.Forms.Button();
            this.buttonRunAnalysis = new System.Windows.Forms.Button();
            this.textBoxAmountPostsToParse = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfLikeForUser = new System.Windows.Forms.TextBox();
            this.labelAmountOfLikesHeader = new System.Windows.Forms.Label();
            this.textBoxAmountOfPosts = new System.Windows.Forms.TextBox();
            this.labelChooseAmountOfPosts = new System.Windows.Forms.Label();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.labelNameOfUser = new System.Windows.Forms.Label();
            this.labelOverallPostHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectedFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDescendingLikeFriends
            // 
            this.listBoxDescendingLikeFriends.FormattingEnabled = true;
            this.listBoxDescendingLikeFriends.Location = new System.Drawing.Point(14, 360);
            this.listBoxDescendingLikeFriends.Name = "listBoxDescendingLikeFriends";
            this.listBoxDescendingLikeFriends.Size = new System.Drawing.Size(120, 212);
            this.listBoxDescendingLikeFriends.TabIndex = 0;
            this.listBoxDescendingLikeFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxDescendingLikeFriends_SelectedIndexChanged);
            // 
            // PictureBoxSelectedFriend
            // 
            this.PictureBoxSelectedFriend.Location = new System.Drawing.Point(178, 360);
            this.PictureBoxSelectedFriend.Name = "PictureBoxSelectedFriend";
            this.PictureBoxSelectedFriend.Size = new System.Drawing.Size(100, 86);
            this.PictureBoxSelectedFriend.TabIndex = 1;
            this.PictureBoxSelectedFriend.TabStop = false;
            // 
            // listBoxRecentPost
            // 
            this.listBoxRecentPost.FormattingEnabled = true;
            this.listBoxRecentPost.Location = new System.Drawing.Point(175, 477);
            this.listBoxRecentPost.Name = "listBoxRecentPost";
            this.listBoxRecentPost.Size = new System.Drawing.Size(200, 95);
            this.listBoxRecentPost.TabIndex = 2;
            // 
            // buttonLikeBack
            // 
            this.buttonLikeBack.Location = new System.Drawing.Point(298, 423);
            this.buttonLikeBack.Name = "buttonLikeBack";
            this.buttonLikeBack.Size = new System.Drawing.Size(75, 23);
            this.buttonLikeBack.TabIndex = 3;
            this.buttonLikeBack.Text = "Like Back";
            this.buttonLikeBack.UseVisualStyleBackColor = true;
            this.buttonLikeBack.Click += new System.EventHandler(this.buttonLikeBack_Click);
            // 
            // buttonRunAnalysis
            // 
            this.buttonRunAnalysis.Location = new System.Drawing.Point(14, 320);
            this.buttonRunAnalysis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRunAnalysis.Name = "buttonRunAnalysis";
            this.buttonRunAnalysis.Size = new System.Drawing.Size(116, 19);
            this.buttonRunAnalysis.TabIndex = 4;
            this.buttonRunAnalysis.Text = "RunAnalysis";
            this.buttonRunAnalysis.UseVisualStyleBackColor = true;
            this.buttonRunAnalysis.Click += new System.EventHandler(this.button_RunAnalysis_Click);
            // 
            // textBoxAmountPostsToParse
            // 
            this.textBoxAmountPostsToParse.Location = new System.Drawing.Point(175, 320);
            this.textBoxAmountPostsToParse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountPostsToParse.Name = "textBoxAmountPostsToParse";
            this.textBoxAmountPostsToParse.Size = new System.Drawing.Size(166, 20);
            this.textBoxAmountPostsToParse.TabIndex = 5;
            // 
            // textBoxAmountOfLikeForUser
            // 
            this.textBoxAmountOfLikeForUser.Location = new System.Drawing.Point(298, 385);
            this.textBoxAmountOfLikeForUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountOfLikeForUser.Name = "textBoxAmountOfLikeForUser";
            this.textBoxAmountOfLikeForUser.Size = new System.Drawing.Size(76, 20);
            this.textBoxAmountOfLikeForUser.TabIndex = 6;
            // 
            // labelAmountOfLikesHeader
            // 
            this.labelAmountOfLikesHeader.AutoSize = true;
            this.labelAmountOfLikesHeader.Location = new System.Drawing.Point(296, 360);
            this.labelAmountOfLikesHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmountOfLikesHeader.Name = "labelAmountOfLikesHeader";
            this.labelAmountOfLikesHeader.Size = new System.Drawing.Size(85, 13);
            this.labelAmountOfLikesHeader.TabIndex = 7;
            this.labelAmountOfLikesHeader.Text = "Amount Of Likes";
            // 
            // textBoxAmountOfPosts
            // 
            this.textBoxAmountOfPosts.Location = new System.Drawing.Point(218, 211);
            this.textBoxAmountOfPosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAmountOfPosts.Name = "textBoxAmountOfPosts";
            this.textBoxAmountOfPosts.ReadOnly = true;
            this.textBoxAmountOfPosts.Size = new System.Drawing.Size(76, 20);
            this.textBoxAmountOfPosts.TabIndex = 9;
            // 
            // labelChooseAmountOfPosts
            // 
            this.labelChooseAmountOfPosts.AutoSize = true;
            this.labelChooseAmountOfPosts.Location = new System.Drawing.Point(176, 296);
            this.labelChooseAmountOfPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseAmountOfPosts.Name = "labelChooseAmountOfPosts";
            this.labelChooseAmountOfPosts.Size = new System.Drawing.Size(167, 13);
            this.labelChooseAmountOfPosts.TabIndex = 10;
            this.labelChooseAmountOfPosts.Text = "Choose how many posts to check";
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Image = global::FacebookApplication.Properties.Resources.CoverDefault;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxCoverPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(490, 200);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 11;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // labelNameOfUser
            // 
            this.labelNameOfUser.AutoSize = true;
            this.labelNameOfUser.Location = new System.Drawing.Point(102, 33);
            this.labelNameOfUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameOfUser.Name = "labelNameOfUser";
            this.labelNameOfUser.Size = new System.Drawing.Size(0, 13);
            this.labelNameOfUser.TabIndex = 12;
            // 
            // labelOverallPostHeader
            // 
            this.labelOverallPostHeader.AutoSize = true;
            this.labelOverallPostHeader.Location = new System.Drawing.Point(93, 215);
            this.labelOverallPostHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOverallPostHeader.Name = "labelOverallPostHeader";
            this.labelOverallPostHeader.Size = new System.Drawing.Size(119, 13);
            this.labelOverallPostHeader.TabIndex = 8;
            this.labelOverallPostHeader.Text = "Overall number of Posts";
            // 
            // LikeAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 582);
            this.Controls.Add(this.labelNameOfUser);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.labelChooseAmountOfPosts);
            this.Controls.Add(this.textBoxAmountOfPosts);
            this.Controls.Add(this.labelOverallPostHeader);
            this.Controls.Add(this.labelAmountOfLikesHeader);
            this.Controls.Add(this.textBoxAmountOfLikeForUser);
            this.Controls.Add(this.textBoxAmountPostsToParse);
            this.Controls.Add(this.buttonRunAnalysis);
            this.Controls.Add(this.buttonLikeBack);
            this.Controls.Add(this.listBoxRecentPost);
            this.Controls.Add(this.PictureBoxSelectedFriend);
            this.Controls.Add(this.listBoxDescendingLikeFriends);
            this.Name = "LikeAnalyzerForm";
            this.Text = "Like Analyzer ";
            this.Load += new System.EventHandler(this.LikeAnalyzerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSelectedFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDescendingLikeFriends;
        private System.Windows.Forms.PictureBox PictureBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxRecentPost;
        private System.Windows.Forms.Button buttonLikeBack;
        private System.Windows.Forms.Button buttonRunAnalysis;
        private System.Windows.Forms.TextBox textBoxAmountPostsToParse;
        private System.Windows.Forms.TextBox textBoxAmountOfLikeForUser;
        private System.Windows.Forms.Label labelAmountOfLikesHeader;
        private System.Windows.Forms.TextBox textBoxAmountOfPosts;
        private System.Windows.Forms.Label labelChooseAmountOfPosts;
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.Label labelNameOfUser;
        private System.Windows.Forms.Label labelOverallPostHeader;
    }
}