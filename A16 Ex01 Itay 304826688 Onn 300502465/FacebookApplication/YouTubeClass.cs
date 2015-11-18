using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace FacebookApplication
{   
    /// <summary>
    /// This Class uses YouTube Api for musicians searches
    /// </summary>
    class YouTubeClass
    {
        private readonly string r_apiKey = "AIzaSyCOW2F8ygyKUMcQInNO0ZBXfeq11yomXdU";
        private List<Tuple<string,string>> m_musicianVideos; 
        private string m_musicianChannelID;
               
        public YouTubeClass()
        {
            m_musicianVideos = new List<Tuple<string,string>>();
        }

        public string getMusicianChannelID
        {
            get
            {
                return m_musicianChannelID;
            }
        }

        public List<Tuple<string, string>> getMusicianVideos
        {
            get
            {
                return m_musicianVideos;
            }
        }

        public async Task YouTubeSearch(String i_Musician)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = r_apiKey,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = i_Musician;
            searchListRequest.MaxResults = 50;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        m_musicianVideos.Add(new Tuple<string,string>(searchResult.Snippet.Title, searchResult.Id.VideoId));
                        break;

                    case "youtube#channel":
                        m_musicianChannelID = searchResult.Id.ChannelId;
                        break;
                }
            }
        }
    }
}
