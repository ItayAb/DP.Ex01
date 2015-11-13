using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace FacebookApplication
{
    class ApplicationConfigurationData
    {
        private const string k_AppId = "843647649088563";
        private readonly string r_FileDirectoryForAppConfig;
        private bool m_IsDataLoaded = false;

        public string m_Token { get; set; }
        
        public ApplicationConfigurationData(string i_PathOfConfigFile)
        {
            r_FileDirectoryForAppConfig = i_PathOfConfigFile;
        }

        public bool LoadData()
        {
            bool resultOfLoading = false;

            if (File.Exists(r_FileDirectoryForAppConfig))
            {
                try
                {
                    StreamReader readDataFromAppConfigFile = new StreamReader(r_FileDirectoryForAppConfig);


                    readDataFromAppConfigFile.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw e;
                }

            }

            return resultOfLoading;           
        }

    }
}
