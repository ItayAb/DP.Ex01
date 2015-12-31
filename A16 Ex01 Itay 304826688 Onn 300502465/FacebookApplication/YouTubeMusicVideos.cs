using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Google.Apis.YouTube.v3;
//using Google.Apis.Services;
using YouTubeSearch;
using System.Threading;

namespace FacebookApplication
{
    class YouTubeMusicVideos : IFetchMusicData<Tuple<string, string>>
    {
        private YouTubeClass m_YouTubeSearchObjectAdoptee;
        private String m_MusicianSelected;
        private List<Tuple<string, string>> m_MusicYouTubeVideosList;

        public YouTubeMusicVideos(String i_MusicianSelected)
        {
            m_MusicianSelected = i_MusicianSelected;
           
        }

        public List<Tuple<string, string>> fetch()
        {
            searchYouTube();

            m_MusicYouTubeVideosList = m_YouTubeSearchObjectAdoptee.getMusicianVideos;

            return m_MusicYouTubeVideosList;
        }

        private async void searchYouTube()
        {
            // initate the youtube object
            if (m_YouTubeSearchObjectAdoptee == null)
            {
                m_YouTubeSearchObjectAdoptee = new YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObjectAdoptee.getMusicianVideos.Clear();
            }

            try
            {
                await m_YouTubeSearchObjectAdoptee.YouTubeSearch(m_MusicianSelected);

                /*
                // if the search not find the channel ID disable the button
                if (string.IsNullOrEmpty(m_YouTubeSearchObjectAdoptee.getMusicianChannelID))
                {
                    buttonYouTubeChannel.Enabled = false;
                }
                 */
            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {
                    
                }
            }
        }
    }
}
