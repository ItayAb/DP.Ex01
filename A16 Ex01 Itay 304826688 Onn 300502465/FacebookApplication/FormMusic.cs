using System;
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
using YouTubeSearch;
using System.Threading;

namespace FacebookApplication
{
    public partial class FormMusic : Form
    {
        private User m_LoggedUser;

        private bool v_FormOpen;

        private FacbookMusicPages m_FacebookMusicPages;

        private YouTubeProxy m_YouTubeProxy;

        private YouTubeVideo m_CurrentVideo;
        private Page m_CurrentPage;

        /// <param name="i_LoggedUser"> get user object from the main form</param>
        public FormMusic(User i_LoggedUser)
        {
            InitializeComponent();

            v_FormOpen = true;

            if (i_LoggedUser != null)
            {
                m_LoggedUser = i_LoggedUser;
                m_FacebookMusicPages = new FacbookMusicPages(m_LoggedUser);
                m_YouTubeProxy = new YouTubeProxy();
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
            // collect
            Thread thread = new Thread(() =>
                {
                    m_FacebookMusicPages.fetch();
                });
            thread.IsBackground = true;
            thread.Start();

            profileName.Text = string.Format("Hello {0}", m_LoggedUser.Name);

            if (!string.IsNullOrEmpty(m_LoggedUser.PictureNormalURL))
            {
                profileImage.LoadAsync(m_LoggedUser.PictureNormalURL);
            }


            thread.Join();


            pageBindingSource.DataSource = m_FacebookMusicPages.get();
            m_YouTubeProxy.SearchProxy(m_CurrentPage.Name);

            //Thread threadYouTube = new Thread(() => m_YouTubeProxy.SearchProxy(m_CurrentPage.Name));
            //threadYouTube.IsBackground = true;
            //threadYouTube.Start();
            //threadYouTube.Join();

            youTubeProxyVideoListBindingSource.DataSource = m_YouTubeProxy.YouTubeVideoList;
            ShockwaveFlashPlayerBox.Movie = m_CurrentVideo.VideoLinkForPlayer;

        }


        private void buttonFetchMusic_Click(object sender, EventArgs e)
        {
            if (m_LoggedUser == null)
            {
                MessageBox.Show("Please login to Facebook First...");
            }
            else
            {

                if (m_LoggedUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :( ");
                }

                /*
                // collect
                Thread thread = new Thread(() => m_FacebookMusicPages.fetch());
                thread.IsBackground = true;
                thread.Start();
                */
                //thread.Join();

                pageBindingSource.DataSource = m_FacebookMusicPages.get();
                /*
                this.Invoke(new Action(() =>
                {
                    pageBindingSource.DataSource = m_FacebookMusicPages.get();
                }));
                 */

                //m_YouTubeProxy.SearchProxy(m_CurrentPage.Name);             
                Thread threadYouTube = new Thread(() => m_YouTubeProxy.SearchProxy(m_CurrentPage.Name));
                threadYouTube.IsBackground = true;
                threadYouTube.Start();
                
                threadYouTube.Join();

                youTubeProxyVideoListBindingSource.DataSource = m_YouTubeProxy.YouTubeVideoList;
                ShockwaveFlashPlayerBox.Movie = m_CurrentVideo.VideoLinkForPlayer;

                /*
                this.Invoke(new Action(() => {
                    youTubeProxyVideoListBindingSource.DataSource = m_YouTubeProxy.YouTubeVideoList;
                    ShockwaveFlashPlayerBox.Movie = m_CurrentVideo.VideoLinkForPlayer;
               }));
                 */
            }
        }


        /// <summary>
        /// method that activate the youtube search and all the data necessary for the form buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusicans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (v_FormOpen)
            {
                //Page selected = pageBindingSource.Current as Page;
                //m_CurrentPage = selected;

                Thread thread = new Thread(() => m_YouTubeProxy.SearchProxy(m_CurrentPage.Name));
                thread.IsBackground = true;
                thread.Start();
                
                //thread.Join();
                
                this.Invoke(new Action(() => 
                {
                    ListBoxMusicianVideos.Enabled = false;
                    youTubeProxyVideoListBindingSource.DataSource = m_YouTubeProxy.YouTubeVideoList;
                    ListBoxMusicianVideos.Enabled = true;
                }));
            }
        }


        private void buttonYouTubeChannel_Click(object sender, EventArgs e)
        {
            if (m_CurrentVideo == null)
            {
                MessageBox.Show("Please Choose a Musician Page First");
            }
            else
            {
                Process.Start(m_CurrentVideo.YouTubeChannelUrl);
            }
        }


        /// <summary>
        /// each time the user select a video the video id changes for the play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusicianVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (v_FormOpen)
            {
                ShockwaveFlashPlayerBox.Movie = m_CurrentVideo.VideoLinkForPlayer;
            }
        }

        private void buttonPlayVideoOnYouTube_Click(object sender, EventArgs e)
        {
            if (m_CurrentVideo.VideoUrl == null)
            {
                MessageBox.Show("Please Choose a Video From the List");
            }
            else
            {
                Process.Start(m_CurrentVideo.VideoUrl);
            }
        }

        private void buttonLinkToPage_Click(object sender, EventArgs e)
        {
            if (m_CurrentPage == null)
            {
                MessageBox.Show("Please Choose a Music Page From The List");
            }
            else
            {
                Process.Start(m_CurrentPage.URL);
            }
        }

        private void MusicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            v_FormOpen = false;
            pageBindingSource.Dispose();
            youTubeProxyVideoListBindingSource.Dispose();
        }

        private void youTubeProxyVideoListBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            m_CurrentVideo = youTubeProxyVideoListBindingSource.Current as YouTubeVideo;
        }

        private void pageBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            m_CurrentPage = pageBindingSource.Current as Page;
        }
    }
}