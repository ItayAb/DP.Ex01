namespace FacebookApplication
{
    partial class AnalysisProgressBar
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
            this.progressBarForLikeAnalysis = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarForLikeAnalysis
            // 
            this.progressBarForLikeAnalysis.Location = new System.Drawing.Point(25, 65);
            this.progressBarForLikeAnalysis.Name = "progressBarForLikeAnalysis";
            this.progressBarForLikeAnalysis.Size = new System.Drawing.Size(370, 23);
            this.progressBarForLikeAnalysis.TabIndex = 0;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(200, 27);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(0, 17);
            this.labelProgress.TabIndex = 1;
            // 
            // AnalysisProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 136);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarForLikeAnalysis);
            this.Name = "AnalysisProgressBar";
            this.Text = "Analysis Progress Bar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarForLikeAnalysis;
        private System.Windows.Forms.Label labelProgress;
    }
}