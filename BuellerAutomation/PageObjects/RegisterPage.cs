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
    class RegisterPage
    {
        public static string BuellerWebsite = "localhost:58469";
        public IWebDriver _driver;
        private static IWebDriver driver = new ChromeDriver(@SystemElements.chromeDriverPath);
        public static IWebElement registerTab { get; set; }
        public static IWebElement register_Email { get; set; }
        public static IWebElement register_Password { get; set; }
        public static IWebElement register_Role { get; set; }
        public static IWebElement register_Button { get; set; }
        public static IWebElement register_FirstName { get; set; }
        public static IWebElement register_MiddleName { get; set; }
        public static IWebElement register_LastName { get; set; }
        public static IWebElement register_Street { get; set; }
        public static IWebElement register_City { get; set; }
        public static IWebElement register_State { get; set; }
        public static IWebElement register_Country { get; set; }
        public static IWebElement register_ZipCode { get; set; }
        public static IWebElement register_PhoneNumber { get; set; }
        public static IWebElement register_ClassLevel { get; set; }
        public static IWebElement register_InformationButton { get; set; }
        public RegisterPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public static void goBuellerWebsite()
        {
            driver.Navigate().GoToUrl(BuellerWebsite);
        }
        public static RegisterPage goRegisterPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Register"))));
            registerTab = driver.FindElement(By.PartialLinkText(@"Register"));
            registerTab.Click();
            Thread.Sleep(2000);
            return new RegisterPage(driver);
        }

        public static RegisterPage registerNewStudent()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[4]/div/input"))));
            register_Email = driver.FindElement(By.Id("Email"));
            register_Password = driver.FindElement(By.Id("Password"));
            register_Role = driver.FindElement(By.Id("role"));
            register_Button = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[4]/div/input"));
            register_Email.SendKeys("newauto@ruralsourcing.com");
            register_Password.SendKeys("automation123!123");
            SelectElement roleDropDown = new SelectElement(register_Role);
            roleDropDown.SelectByText("student");
            Thread.Sleep(2000);
            register_Button.Click();
            return new RegisterPage(driver);
        }

        public static RegisterPage registerNewFreshman()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[11]/div/input"))));
            register_InformationButton = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[11]/div/input"));
            register_FirstName = driver.FindElement(By.Id("FirstName"));
            register_FirstName.SendKeys("Automation");
            register_MiddleName = driver.FindElement(By.Id("MiddleName"));
            register_MiddleName.SendKeys("The");
            register_LastName = driver.FindElement(By.Id("LastName"));
            register_LastName.SendKeys("Worker");
            register_Street = driver.FindElement(By.Id("Street"));
            register_Street.SendKeys("723 Silver Ave NW");
            register_City = driver.FindElement(By.Id("City"));
            register_City.SendKeys("Albuquerque");
            register_State = driver.FindElement(By.Id("State"));
            register_State.SendKeys("New Mexico");
            register_Country = driver.FindElement(By.Id("Country"));
            register_Country.SendKeys("United States");
            register_ZipCode = driver.FindElement(By.Id("Zipcode"));
            register_ZipCode.SendKeys("87120");
            register_PhoneNumber = driver.FindElement(By.Id("PhoneNumber"));
            register_PhoneNumber.SendKeys("(504) 819-2301");
            register_ClassLevel = driver.FindElement(By.Id("Grade"));
            SelectElement classlevelDropDown = new SelectElement(register_ClassLevel);
            classlevelDropDown.SelectByValue("Freshman");
            Thread.Sleep(2000);
            register_InformationButton.Click();
            return new RegisterPage(driver);
        }
    }
}
