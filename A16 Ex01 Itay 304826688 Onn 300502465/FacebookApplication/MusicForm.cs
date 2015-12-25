﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using YouTubeSearch;

namespace FacebookApplication
{
    public partial class MusicForm : Form
    {
        private readonly string r_youTubeChannelLink = "https://www.youtube.com/channel/";
        private readonly string r_youTubeVideoLink = "https://www.youtube.com/watch?v=";
        private readonly string r_youTubeVideoLinkForPlayer = "https://www.youtube.com/v/";
        private User m_LoggedUser;
        private List<Page> m_PagesList;
        private YouTubeClass m_YouTubeSearchObject;
        private string m_MusicainSelected;
        private string m_VideoId;
        private string m_PageUrl;

        /// <param name="i_LoggedUser"> get user object from the main form</param>
        public MusicForm(User i_LoggedUser)
        {
            InitializeComponent();

            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                m_PagesList = new List<Page>();
                initMusicForm();
            }
        }

        public User LoggedUser
        {
            get
            {
                return m_LoggedUser;
            }

            set
            {
                m_LoggedUser = value;
            }
        }

        // load the user profile picture and init welcome message
        private void initMusicForm()
        {            
            profileName.Text = string.Format("Hello {0}", m_LoggedUser.Name);

            if (!string.IsNullOrEmpty(m_LoggedUser.PictureNormalURL))
            {
                profileImage.LoadAsync(m_LoggedUser.PictureNormalURL);
            }
        }

        // fetches the pages and filtring the pages of Musicians
        private void fetchPages()
        {
            ListBoxMusicans.Items.Clear();

            if (m_LoggedUser.LikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :( ");
            }

            ListBoxMusicans.DisplayMember = "Name";

            foreach (Page page in m_LoggedUser.LikedPages)
            {
                if (page.Category == "Musician/Band")
                {
                    ListBoxMusicans.Items.Add(page);
                }
            }
        }

        private void buttonFetchMusic_Click(object sender, EventArgs e)
        {
            if (m_LoggedUser == null)
            {
                MessageBox.Show("Please login to Facebook First...");
            }
            else
            {
                fetchPages();
            }
        }

        /// <summary>
        /// async method that activate the youtube search and all the data necessary for the form buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ListBoxMusicans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxMusicans.Enabled = false;
            ListBoxMusicianVideos.Items.Clear();

            Page selectedPage = ListBoxMusicans.SelectedItem as Page;

            if (selectedPage != null)
            {
                if (!string.IsNullOrEmpty(selectedPage.PictureLargeURL))
                {
                    musicianImage.LoadAsync(selectedPage.PictureLargeURL);
                }

                m_MusicainSelected = selectedPage.Name;

                string pageLikes = "Page Likes: ";
                labelPageLikes.Text = string.Format("{0}\n{1}", pageLikes, selectedPage.LikesCount.ToString());
                m_PageUrl = selectedPage.URL;
            }

            // initate the youtube object
            if (m_YouTubeSearchObject == null)
            {
                m_YouTubeSearchObject = new YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObject.getMusicianVideos.Clear();
            }

            try
            {
                await m_YouTubeSearchObject.YouTubeSearch(m_MusicainSelected);

                // if the search not find the channel ID disable the button
                if (string.IsNullOrEmpty(m_YouTubeSearchObject.getMusicianChannelID))
                {
                    buttonYouTubeChannel.Enabled = false;
                }
            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {
                    MessageBox.Show(error.Message);
                }
            }

            fetchMusicianVideos();
            ListBoxMusicans.Enabled = true;
        }

        private void buttonYouTubeChannel_Click(object sender, EventArgs e)
        {
            if (m_YouTubeSearchObject == null)
            {
                MessageBox.Show("Please Choose a Musician Page First");
            }
            else
            {
                Process.Start(string.Format("{0}{1}", r_youTubeChannelLink, m_YouTubeSearchObject.getMusicianChannelID));
            }
        }

        /// <summary>
        /// get the top videos of the musician from youtube and reflect the resultes to the user
        /// </summary>
        private void fetchMusicianVideos()
        {
            ListBoxMusicianVideos.Items.Clear();

            if (m_YouTubeSearchObject.getMusicianVideos.Count == 0)
            {
                MessageBox.Show("No Videos to retrieve :(");
            }
            else
            {
                foreach (Tuple<string, string> tuple in m_YouTubeSearchObject.getMusicianVideos)
                {
                    ListBoxMusicianVideos.DisplayMember = "tuple.Item1";
                    ListBoxMusicianVideos.Items.Add(tuple);
                }
            }
        }

        /// <summary>
        /// each time the user select a video the video id changes for the play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusicianVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tuple<string, string> selectedItem = ListBoxMusicianVideos.SelectedItem as Tuple<string, string>;
            m_VideoId = selectedItem.Item2;
            ShockwaveFlashPlayerBox.Movie = string.Format("{0}{1}", r_youTubeVideoLinkForPlayer, m_VideoId);
        }

        private void buttonPlayVideoOnYouTube_Click(object sender, EventArgs e)
        {
            if (m_VideoId == null)
            {
                MessageBox.Show("Please Choose a Video From the List");
            }
            else
            {
                Process.Start(string.Format("{0}{1}", r_youTubeVideoLink, m_VideoId));
            }
        }

        private void buttonLinkToPage_Click(object sender, EventArgs e)
        {
            if (m_PageUrl == null)
            {
                MessageBox.Show("Please Choose a Music Page From The List");
            }
            else
            {
                Process.Start(m_PageUrl);
            }
        }
    }
}
