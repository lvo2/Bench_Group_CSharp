using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;


namespace Automation_Practice.Common
{
    
    public abstract class Browser
    {
        private IWebDriver driver;
        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }

         public IWebDriver Driver
        {
            get { return this.driver; }
        }
        public abstract void Navigate(string url);

        public void Close()
        {
            this.driver.Quit();
        }

       

    }
}
