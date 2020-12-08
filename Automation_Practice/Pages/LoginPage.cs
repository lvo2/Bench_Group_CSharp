using OpenQA.Selenium;
using Automation_Practice.Common;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;

namespace Automation_Practice.Pages
{
    public class LoginPage
    {
        public LoginPage(Browser browser) 
        {
            PageFactory.InitElements(browser.Driver, this);
        }

        //readonly Browser browser = ScenarioContext.Current.Get<Browser>("key_browser");

        /// <summary>
        /// The sign in the practice automation page
        /// </summary>
        [FindsBy(How = How.ClassName, Using = "login")]
        private IWebElement _login = null;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement _email = null;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement _SubmitLogin = null;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement _passwd = null;

        [FindsBy(How = How.ClassName, Using = "logout")]
        private IWebElement _logout = null;

        public bool IsSignInButton()
        {
            try
            {
                return  _login.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void ClickSignInButton()
        {
            _login.Click();
        }

        public void SetEmailValue()
        {
            _email.SendKeys("vongoclien@gmail.com");
        }

        public void SetPasswordValue()
        {
            _passwd.SendKeys("lienvo@123");
        }

        public void ClickSubmitSignIn()
        {
            _SubmitLogin.Click();
        }

        public bool IsSignOut()
        {
            try
            {
                return _logout.Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}
