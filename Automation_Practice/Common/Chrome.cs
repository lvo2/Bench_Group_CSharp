using OpenQA.Selenium.Chrome;

namespace Automation_Practice.Common

{
    public class Chrome : Browser
    {
      
        public Chrome(string driverPath, ChromeOptions options)
            : base(new ChromeDriver(driverPath, options))
        {
        }

        public override void Navigate(string url)
        {
            this.Driver.Navigate().GoToUrl(url);
        }
    }
}
