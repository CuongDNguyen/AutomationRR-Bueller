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
        public static IWebElement logoutButton { get; set; }
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
        public static ProfilePage teacherLogin()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btnSubmit")));
            login_Email = driver.FindElement(By.Id("email"));
            login_Password = driver.FindElement(By.Id("Password"));
            login_Button = driver.FindElement(By.Id("btnSubmit"));
            login_Email.SendKeys("teachernewauto31234@ruralsourcing.com");
            login_Password.SendKeys("automation123!123");
            Thread.Sleep(2000);
            login_Button.Click();
            return new ProfilePage(driver);
        }

        public static ProfilePage goProfilePage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.LinkText("Profile"))));
            profileTab = driver.FindElement(By.LinkText("Profile"));
            profileTab.Click();
            return new ProfilePage(driver);
        }
        public static ProfilePage editUserProfile()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.LinkText("Edit"))));
            editProfile = driver.FindElement(By.LinkText("Edit"));
            editProfile.Click();
            var loading2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[11]/div/input"))));
            profile_saveButton = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[11]/div/input"));
            profile_FirstName = driver.FindElement(By.Id("FirstName"));
            profile_FirstName.Clear();
            profile_FirstName.SendKeys("editAutomation");
            profile_MiddleName = driver.FindElement(By.Id("MiddleName"));
            profile_MiddleName.Clear();
            profile_MiddleName.SendKeys("editMiddleName");
            profile_LastName = driver.FindElement(By.Id("LastName"));
            profile_LastName.Clear();
            profile_LastName.SendKeys("editLastName");
            profile_ClassLevel = driver.FindElement(By.Id("Grade"));
            SelectElement gradeDropdown = new SelectElement(profile_ClassLevel);
            gradeDropdown.SelectByValue("Junior");
            profile_PhoneNumber = driver.FindElement(By.Id("PhoneNumber"));
            profile_PhoneNumber.Clear();
            profile_PhoneNumber.SendKeys("(909) 951-4123");
            profile_Street = driver.FindElement(By.Id("Street"));
            profile_Street.Clear();
            profile_Street.SendKeys("154 edit Street");
            profile_City = driver.FindElement(By.Id("City"));
            profile_City.Clear();
            profile_City.SendKeys("edit Albuquerque edit");
            profile_State = driver.FindElement(By.Id("State"));
            profile_State.Clear();
            profile_State.SendKeys("edit NewMexico edit");
            profile_Country = driver.FindElement(By.Id("Country"));
            profile_Country.Clear();
            profile_Country.SendKeys("edit United States edit");
            profile_Zipcode = driver.FindElement(By.Id("Zipcode"));
            profile_Zipcode.Clear();
            profile_Zipcode.SendKeys("90213");
            Thread.Sleep(2000);
            profile_saveButton.Click();
            return new ProfilePage(driver);
        }
        public static ProfilePage logout()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Logout"))));
            logoutButton = driver.FindElement(By.PartialLinkText("Logout"));
            logoutButton.Click();
            return new ProfilePage(driver);
        }
        public static void quitBrowser()
        {
            driver.Quit();
        }
    }
}
