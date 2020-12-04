using System;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace Automation_Practice.Common
{
    public class BrowserFactory
    {
        private static BrowserFactory _instance = null;      

        public static BrowserFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BrowserFactory();
                }
                return _instance;
            }
        }

       public Browser InitBrowser(string browserName)
        {          
            switch (Configuration.Instance.Browser.ToUpper())
            {
                case "CHROME":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--lang=en-US");
                    options.AddArguments("--start-maximized");
                    options.AddArguments("--no-sandbox");
                    options.AddArguments("--disable-popup-blocking");
                    options.AddArguments("--allow-running-insecure-content");
                    options.AddWindowType("webview");
                    return new Chrome(Configuration.Instance.DriverPath, options);
                case "FIREFOX":
                  // define firefox browser
                default:
                    throw new ArgumentException("unknown browser type: " + Configuration.Instance.Browser.ToUpper());
            }        
        }
    }
}
