using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Automation_Practice.Common
{
    public class Configuration
    {
        
        private static Configuration _instance;
       
        private Configuration()
        {
            LoadConfigData();
        }
     
        public static Configuration Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }

                return _instance;
            }
        }

       public string Browser { get; set; }             
      
        public string PracticeWebsite { get; set; }
        public string GoogleWebsite { get; set; }

        public int Timeout { get; set; }      
        public string DriverPath { get; set; }
        public string CurrentDirectory { get; private set; }

        public void LoadConfigData()
        {
            try
            {
                // set current directory path
                var directoryInfo = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory;
                if (directoryInfo != null
                )
                    CurrentDirectory =
                        directoryInfo
                            .FullName + "\\";

            //Prepare configuration.xml file path
            //Note that in order to have Visual Studio and AutomationRunner both use the same
            //configuration file, this project is using the config file in the project's \bin\Debug sub-folder
            // string configFilePath = CurrentDirectory + ConfigurationManager.AppSettings["ConfigFile"];
                string configFilePath = CurrentDirectory + "Configuration.xml";

                if (!File.Exists(configFilePath))
                {
                    throw new FileNotFoundException(configFilePath);
                }

                XmlDocument configDoc = new XmlDocument();
                configDoc.Load(configFilePath);
                XmlElement root = configDoc.DocumentElement;
                Console.WriteLine("Tests are using config file path=" + configFilePath);
                DriverPath = CurrentDirectory;
                Browser = GetValuesFromXML("TestEnvironment", "Browser", root);
                PracticeWebsite = GetValuesFromXML("TestEnvironment", "PracticeWebsite", root);
                GoogleWebsite = GetValuesFromXML("TestEnvironment", "GoogleWebsite", root);
            }
            catch (Exception exception)
            {
                // Print exception on console
                Console.WriteLine("Exception in LoadConfigData " + exception.Message);
                throw;
            }
        }
        public string GetValuesFromXML(string nodeName, string attributeName, XmlElement root, string defaultValue = "")
        {
            try
            {
                // assign attribute as a normal to file
                XmlNodeList nodes = root.SelectNodes("//" + nodeName);
                if (nodes != null && nodes.Count < 1)
                {
                    throw new Exception("Xml Node not found for [" + nodeName + "]");
                }

                if (nodes != null)
                    for (var index = 0; index < nodes.Count; index++)
                    {
                        XmlNode node = nodes[index];
                        defaultValue = node[attributeName]?.InnerText;
                    }

                return defaultValue;
            }
            catch (Exception exception)
            {
                throw new Exception("Exception Occur In Read Xml File.", exception);
            }
        }
        
    }
}
