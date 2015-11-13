using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    class ApplicationConfigurationData
    {
        private string m_AccessToken;

        public ApplicationConfigurationData()
        {
        }

        public string AccessToken
        {
            get { return m_AccessToken; }
            set { m_AccessToken = value; }
        }
    }
}
