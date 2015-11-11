using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApplication
{
    class LikeAnalyzer
    {
        Dictionary<User, int> m_LikeDataAnalysis;
        User m_LoggedUser;

        public LikeAnalyzer(User i_LoggedUser)
        {
            m_LikeDataAnalysis = new Dictionary<User, int>();
            m_LoggedUser = i_LoggedUser;
        }

        private void calculateLikeToList()
        {    
            // iterating all the posts 
            foreach (Post postCurrentlyCalculating in m_LoggedUser.Posts)
            {
                // iterating all user who liked the post
                foreach (User userWhoLikedThePost in postCurrentlyCalculating.LikedBy)
                {
                    // if the user already appeared in previous calculations
                    if (m_LikeDataAnalysis.ContainsKey(userWhoLikedThePost))
                    {
                        int likeCountForCurrentCalculatedUser = m_LikeDataAnalysis[userWhoLikedThePost];
                        likeCountForCurrentCalculatedUser++;
                        m_LikeDataAnalysis[userWhoLikedThePost] = likeCountForCurrentCalculatedUser;
                    }
                    else
                    {
                        m_LikeDataAnalysis.Add(userWhoLikedThePost, 1);
                    }
                }
            }
        }

        public List<User> GetDescendingTopLikeUserList()
        {
            List<User> topLikeUsers = new List<User>();

            foreach (KeyValuePair<User, int> currentPairInCalculatedData in m_LikeDataAnalysis.OrderByDescending(Key => Key.Value ))
            {
                topLikeUsers.Add(currentPairInCalculatedData.Key);
            }

            return topLikeUsers;
        }
              
    }
}
