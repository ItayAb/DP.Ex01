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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListView_Posts = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
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
            this.picture_ProfilePhoto.Location = new System.Drawing.Point(260, 52);
            this.picture_ProfilePhoto.Name = "picture_ProfilePhoto";
            this.picture_ProfilePhoto.Size = new System.Drawing.Size(125, 125);
            this.picture_ProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture_ProfilePhoto.TabIndex = 1;
            this.picture_ProfilePhoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Group View";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Like Analyzer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListView_Posts
            // 
            this.ListView_Posts.Location = new System.Drawing.Point(158, 292);
            this.ListView_Posts.Name = "ListView_Posts";
            this.ListView_Posts.Size = new System.Drawing.Size(327, 363);
            this.ListView_Posts.TabIndex = 4;
            this.ListView_Posts.UseCompatibleStateImageBehavior = false;
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
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(279, 23);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(91, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 654);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListView_Posts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView ListView_Posts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLogin;
    }
}

