using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuellerAutomation.PageObjects
{
    class ProfilePage
    {
        public static string BuellerWebsite = "localhost:58469";
        public IWebDriver _driver;
        private static IWebDriver driver = new ChromeDriver(@SystemElements.chromeDriverPath);
        public static IWebElement loginTab { get; set; }
        public static IWebElement login_Email { get; set; }
        public static IWebElement login_Password { get; set; }
        public static IWebElement login_Button { get; set; }
        public static IWebElement profileTab { get; set; }
        public static IWebElement editProfile { get; set; }
        public static IWebElement profile_FirstName { get; set; }
        public static IWebElement profile_MiddleName { get; set; }
        public static IWebElement profile_LastName { get; set; }
        public static IWebElement profile_ClassLevel { get; set; }
        public static IWebElement profile_PhoneNumber { get; set; }
        public static IWebElement profile_Street { get; set; }
        public static IWebElement profile_City { get; set; }
        public static IWebElement profile_State { get; set; }
        public static IWebElement profile_Country { get; set; }
        public static IWebElement profile_Zipcode { get; set; }
        public static IWebElement profile_saveButton { get; set; }
        public ProfilePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public static void goBuellerWebsite()
        {
            driver.Navigate().GoToUrl(BuellerWebsite);
        }

        public static ProfilePage goLoginPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Login"))));
            loginTab = driver.FindElement(By.PartialLinkText(@"Login"));
            loginTab.Click();
            return new ProfilePage(driver);
        }
        public static ProfilePage userLogin()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btnSubmit")));
            login_Email = driver.FindElement(By.Id("email"));
            login_Password = driver.FindElement(By.Id("Password"));
            login_Button = driver.FindElement(By.Id("btnSubmit"));
            login_Email.SendKeys("automationStudent1@ruralsourcing.com");
            login_Password.SendKeys("automation123!");
            Thread.Sleep(2000);
            login_Button.Click();
            return new ProfilePage(driver);
        }
    }
}
