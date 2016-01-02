using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeSearch;

namespace FacebookApplication
{
    class YouTubeProxy1
    {
        private Dictionary<string, List<YouTubeVideo>> m_CacheVideos;

        private YouTubeClass m_YouTubeSearchObject;

        private string m_Musician;



        //public Dictionary<string, List<YouTubeVideo>> CachedVideos { get; }

        public List<YouTubeVideo> SearchProxy(string i_Musician)
        {
            m_Musician = i_Musician;
            List<YouTubeVideo> result = new List<YouTubeVideo>();
            //check if the Dictionary was initilized
            if (m_CacheVideos == null)
            {
                m_CacheVideos = new Dictionary<string, List<YouTubeVideo>>();
            }

            if (m_CacheVideos.ContainsKey(m_Musician))
            {
                result = m_CacheVideos[m_Musician];
            }
            else
            {
                //searchYouTube();
                //activeSearch();

                searchYouTube();
                updateCached();

                if (m_CacheVideos.ContainsKey(m_Musician))
                {
                    result = m_CacheVideos[m_Musician];
                }
                else
                {
                    result = null;
                }
            }

            return result;
        }


        public async void activeSearch()
        {
            /*
            Task<string> searchTask = searchYouTube();

            while (searchTask.IsCompleted)
            {
                return;
            }
            string res = await searchTask;
            //await searchYouTube();
        */
        }



        private void searchYouTube()
        {
            // initate the youtube object
            if (m_YouTubeSearchObject == null)
            {
                m_YouTubeSearchObject = new YouTubeSearch.YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObject.getMusicianVideos.Clear();
            }

            try
            {
                m_YouTubeSearchObject.YouTubeSearch(m_Musician);

                Console.WriteLine("Finished Search");

            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {

                }
            }

        }

        /*
        private async Task<string> searchYouTube()
        {
            // initate the youtube object
            if (m_YouTubeSearchObject == null)
            {
                m_YouTubeSearchObject = new YouTubeSearch.YouTubeClass();
            }
            else
            {
                m_YouTubeSearchObject.getMusicianVideos.Clear();
            }

            try
            {
                //await m_YouTubeSearchObject.YouTubeSearch(m_Musician);

                Console.WriteLine("Finished Search");

            }
            catch (AggregateException errors)
            {
                foreach (Exception error in errors.InnerExceptions)
                {

                }
            }

            return "Done";
        }
         */

        private void updateCached()
        {

            List<YouTubeVideo> videoList = new List<YouTubeVideo>();

            if (m_YouTubeSearchObject != null)
            {
                foreach (Tuple<string, string> v in m_YouTubeSearchObject.getMusicianVideos)
                {
                    YouTubeVideo videoToAdd = new YouTubeVideo();
                    videoToAdd.VideoKey = v.Item2;
                    videoToAdd.VideoName = v.Item1;

                    videoList.Add(videoToAdd);
                }
            }

            m_CacheVideos.Add(m_Musician, videoList);
        }

    }
}
