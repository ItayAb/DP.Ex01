﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication
{
    public partial class AnalysisProgressBar : Form
    {
        
        int m_NumOfPosts;        

        public AnalysisProgressBar(int i_numOfPosts)
        {
            InitializeComponent();
            m_NumOfPosts = i_numOfPosts;            
            initProgress();
        }

        public void resetProgress(int i_NumOfPosts)
        {
            m_NumOfPosts = i_NumOfPosts;
            initProgress();
        }

        private void initProgress()
        {
            progressBarForLikeAnalysis.Value = 0;            
            progressBarForLikeAnalysis.Minimum = 0;
            progressBarForLikeAnalysis.Maximum = m_NumOfPosts;
            progressBarForLikeAnalysis.Step = 1;            
        }

        public void incrementProgressBar()
        {                     
            progressBarForLikeAnalysis.PerformStep();
            // TODO: think of a better way to increment, delegate?                        
            if (progressBarForLikeAnalysis.Value == progressBarForLikeAnalysis.Maximum)
            {
                this.Close();    
            }
        }        
    }
}
