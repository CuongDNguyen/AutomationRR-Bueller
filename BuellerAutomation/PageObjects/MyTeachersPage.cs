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
    class MyTeachersPage
    {
        public static string BuellerWebsite = "localhost:58469";
        public IWebDriver _driver;
        private static IWebDriver driver = new ChromeDriver(@SystemElements.chromeDriverPath);
        public static IWebElement loginTab { get; set; }
        public static IWebElement login_Email { get; set; }
        public static IWebElement login_Password { get; set; }
        public static IWebElement login_Button { get; set; }
        public static IWebElement logoutButton { get; set; }
        public static IWebElement myTeacherTab { get; set; }
        public MyTeachersPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public static void goBuellerWebsite()
        {
            driver.Navigate().GoToUrl(BuellerWebsite);
        }

        public static MyTeachersPage goLoginPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Login"))));
            loginTab = driver.FindElement(By.PartialLinkText(@"Login"));
            loginTab.Click();
            return new MyTeachersPage(driver);
        }
        public static MyTeachersPage userLogin()
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
            return new MyTeachersPage(driver);
        }
        public static MyTeachersPage goMyTeachersPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("My Teachers")));
            myTeacherTab = driver.FindElement(By.PartialLinkText("My Teachers"));
            myTeacherTab.Click();
            Thread.Sleep(2000);
            return new MyTeachersPage(driver);
        }
        public static MyTeachersPage logout()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Logout"))));
            logoutButton = driver.FindElement(By.PartialLinkText("Logout"));
            logoutButton.Click();
            return new MyTeachersPage(driver);
        }
        public static void quitBrowser()
        {
            driver.Quit();
        }
    }
}
