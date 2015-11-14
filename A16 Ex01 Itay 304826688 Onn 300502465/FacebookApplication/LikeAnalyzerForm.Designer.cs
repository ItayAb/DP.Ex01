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
            this.listBox_DescendingLikeFriends = new System.Windows.Forms.ListBox();
            this.PictureBox_SelectedFriend = new System.Windows.Forms.PictureBox();
            this.listBox_RecentPost = new System.Windows.Forms.ListBox();
            this.button_LikeBack = new System.Windows.Forms.Button();
            this.button_RunAnalysis = new System.Windows.Forms.Button();
            this.textBox_AmountPostsToParse = new System.Windows.Forms.TextBox();
            this.textBox_AmountOfLikeForUser = new System.Windows.Forms.TextBox();
            this.label_AmountOfLikes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AmountOfPosts = new System.Windows.Forms.TextBox();
            this.label_ChooseAmountOfPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SelectedFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_DescendingLikeFriends
            // 
            this.listBox_DescendingLikeFriends.FormattingEnabled = true;
            this.listBox_DescendingLikeFriends.ItemHeight = 16;
            this.listBox_DescendingLikeFriends.Location = new System.Drawing.Point(16, 246);
            this.listBox_DescendingLikeFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_DescendingLikeFriends.Name = "listBox_DescendingLikeFriends";
            this.listBox_DescendingLikeFriends.Size = new System.Drawing.Size(159, 260);
            this.listBox_DescendingLikeFriends.TabIndex = 0;
            this.listBox_DescendingLikeFriends.SelectedIndexChanged += new System.EventHandler(this.listBox_DescendingLikeFriends_SelectedIndexChanged);
            // 
            // PictureBox_SelectedFriend
            // 
            this.PictureBox_SelectedFriend.Location = new System.Drawing.Point(233, 246);
            this.PictureBox_SelectedFriend.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox_SelectedFriend.Name = "PictureBox_SelectedFriend";
            this.PictureBox_SelectedFriend.Size = new System.Drawing.Size(133, 106);
            this.PictureBox_SelectedFriend.TabIndex = 1;
            this.PictureBox_SelectedFriend.TabStop = false;
            // 
            // listBox_RecentPost
            // 
            this.listBox_RecentPost.FormattingEnabled = true;
            this.listBox_RecentPost.ItemHeight = 16;
            this.listBox_RecentPost.Location = new System.Drawing.Point(233, 390);
            this.listBox_RecentPost.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_RecentPost.Name = "listBox_RecentPost";
            this.listBox_RecentPost.Size = new System.Drawing.Size(265, 116);
            this.listBox_RecentPost.TabIndex = 2;
            // 
            // button_LikeBack
            // 
            this.button_LikeBack.Location = new System.Drawing.Point(400, 324);
            this.button_LikeBack.Margin = new System.Windows.Forms.Padding(4);
            this.button_LikeBack.Name = "button_LikeBack";
            this.button_LikeBack.Size = new System.Drawing.Size(100, 28);
            this.button_LikeBack.TabIndex = 3;
            this.button_LikeBack.Text = "Like Back";
            this.button_LikeBack.UseVisualStyleBackColor = true;
            // 
            // button_RunAnalysis
            // 
            this.button_RunAnalysis.Location = new System.Drawing.Point(251, 118);
            this.button_RunAnalysis.Name = "button_RunAnalysis";
            this.button_RunAnalysis.Size = new System.Drawing.Size(154, 23);
            this.button_RunAnalysis.TabIndex = 4;
            this.button_RunAnalysis.Text = "RunAnalysis";
            this.button_RunAnalysis.UseVisualStyleBackColor = true;
            this.button_RunAnalysis.Click += new System.EventHandler(this.button_RunAnalysis_Click);
            // 
            // textBox_AmountPostsToParse
            // 
            this.textBox_AmountPostsToParse.Location = new System.Drawing.Point(421, 118);
            this.textBox_AmountPostsToParse.Name = "textBox_AmountPostsToParse";
            this.textBox_AmountPostsToParse.Size = new System.Drawing.Size(220, 22);
            this.textBox_AmountPostsToParse.TabIndex = 5;
            // 
            // textBox_AmountOfLikeForUser
            // 
            this.textBox_AmountOfLikeForUser.Location = new System.Drawing.Point(398, 263);
            this.textBox_AmountOfLikeForUser.Name = "textBox_AmountOfLikeForUser";
            this.textBox_AmountOfLikeForUser.Size = new System.Drawing.Size(100, 22);
            this.textBox_AmountOfLikeForUser.TabIndex = 6;
            // 
            // label_AmountOfLikes
            // 
            this.label_AmountOfLikes.AutoSize = true;
            this.label_AmountOfLikes.Location = new System.Drawing.Point(400, 240);
            this.label_AmountOfLikes.Name = "label_AmountOfLikes";
            this.label_AmountOfLikes.Size = new System.Drawing.Size(112, 17);
            this.label_AmountOfLikes.TabIndex = 7;
            this.label_AmountOfLikes.Text = "Amount Of Likes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Overall number of Posts";
            // 
            // textBox_AmountOfPosts
            // 
            this.textBox_AmountOfPosts.Location = new System.Drawing.Point(421, 34);
            this.textBox_AmountOfPosts.Name = "textBox_AmountOfPosts";
            this.textBox_AmountOfPosts.ReadOnly = true;
            this.textBox_AmountOfPosts.Size = new System.Drawing.Size(100, 22);
            this.textBox_AmountOfPosts.TabIndex = 9;
            // 
            // label_ChooseAmountOfPosts
            // 
            this.label_ChooseAmountOfPosts.AutoSize = true;
            this.label_ChooseAmountOfPosts.Location = new System.Drawing.Point(423, 98);
            this.label_ChooseAmountOfPosts.Name = "label_ChooseAmountOfPosts";
            this.label_ChooseAmountOfPosts.Size = new System.Drawing.Size(218, 17);
            this.label_ChooseAmountOfPosts.TabIndex = 10;
            this.label_ChooseAmountOfPosts.Text = "Choose how many posts to check";
            // 
            // LikeAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 615);
            this.Controls.Add(this.label_ChooseAmountOfPosts);
            this.Controls.Add(this.textBox_AmountOfPosts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_AmountOfLikes);
            this.Controls.Add(this.textBox_AmountOfLikeForUser);
            this.Controls.Add(this.textBox_AmountPostsToParse);
            this.Controls.Add(this.button_RunAnalysis);
            this.Controls.Add(this.button_LikeBack);
            this.Controls.Add(this.listBox_RecentPost);
            this.Controls.Add(this.PictureBox_SelectedFriend);
            this.Controls.Add(this.listBox_DescendingLikeFriends);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LikeAnalyzerForm";
            this.Text = "Like Analyzer ";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SelectedFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_DescendingLikeFriends;
        private System.Windows.Forms.PictureBox PictureBox_SelectedFriend;
        private System.Windows.Forms.ListBox listBox_RecentPost;
        private System.Windows.Forms.Button button_LikeBack;
        private System.Windows.Forms.Button button_RunAnalysis;
        private System.Windows.Forms.TextBox textBox_AmountPostsToParse;
        private System.Windows.Forms.TextBox textBox_AmountOfLikeForUser;
        private System.Windows.Forms.Label label_AmountOfLikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AmountOfPosts;
        private System.Windows.Forms.Label label_ChooseAmountOfPosts;
    }
}