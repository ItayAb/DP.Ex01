using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

//using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace FacebookApplication
{
    class YouTubeClass
    {

        /// <summary>
        /// YouTube Data API v3 sample: search by keyword.
        /// Relies on the Google APIs Client Library for .NET, v1.7.0 or higher.
        /// See https://code.google.com/p/google-api-dotnet-client/wiki/GettingStarted
        ///
        /// Set ApiKey to the API key value from the APIs & auth > Registered apps tab of
        ///   https://cloud.google.com/console
        /// Please ensure that you have enabled the YouTube Data API for your project.
        /// </summary>
        /// 
        public List<Tuple<string,string>> m_musicianVideos;
        //private List<string> channels; 
        private List<string> playlists; 
        private readonly String r_apiKey = "AIzaSyCOW2F8ygyKUMcQInNO0ZBXfeq11yomXdU";
        //TODO: Check if its the best way to pass var between classes
        
        public String m_musicianChannelID { get; set; }

        public YouTubeClass()
        {
            
            m_musicianVideos = new List<Tuple<string,string>>();
            //channels = new List<string>();
            playlists = new List<string>();
        }

        public async Task YouTubeSearch(String i_Musician)
        {

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = r_apiKey,
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = i_Musician; // Replace with your search term.
            searchListRequest.MaxResults = 50;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = await searchListRequest.ExecuteAsync();

            // Add each result to the appropriate list, and then display the lists of
            // matching videos, channels, and playlists.
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":
                        m_musicianVideos.Add(new Tuple<string,string>(searchResult.Snippet.Title, searchResult.Id.VideoId));
                        //videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                        break;

                    case "youtube#channel":
                        //channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        m_musicianChannelID = searchResult.Id.ChannelId;
                        break;

                    case "youtube#playlist":
                        playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        break;
                }

                Console.WriteLine("Check the list...");
            }
        }
    }

}
