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
    class AllClassesPage
    {
        public static string BuellerWebsite = "localhost:58469";
        public IWebDriver _driver;
        private static IWebDriver driver = new ChromeDriver(@SystemElements.chromeDriverPath);
        public static IWebElement loginTab { get; set; }
        public static IWebElement login_Email { get; set; }
        public static IWebElement login_Password { get; set; }
        public static IWebElement login_Button { get; set; }
        public static IWebElement logoutButton { get; set; }
        public static IWebElement allClassesTab { get; set; }
        public static IWebElement newClassButton { get; set; }
        public static IWebElement create_Subject { get; set; }
        public static IWebElement create_Name { get; set; }
        public static IWebElement create_Section { get; set; }
        public static IWebElement create_Credits { get; set; }
        public static IWebElement create_Description { get; set; }
        public static IWebElement create_Mon { get; set; }
        public static IWebElement create_Tue { get; set; }
        public static IWebElement create_Wed { get; set; }
        public static IWebElement create_Thurs { get; set; }
        public static IWebElement create_Fri { get; set; }
        public static IWebElement create_StartTime { get; set; }
        public static IWebElement create_EndTime { get; set; }
        public static IWebElement create_Room { get; set; }
        public static IWebElement create_Button { get; set; }
        public AllClassesPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public static void goBuellerWebsite()
        {
            driver.Navigate().GoToUrl(BuellerWebsite);
        }

        public static AllClassesPage goLoginPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Login"))));
            loginTab = driver.FindElement(By.PartialLinkText(@"Login"));
            loginTab.Click();
            return new AllClassesPage(driver);
        }
        public static AllClassesPage userLogin()
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
            return new AllClassesPage(driver);
        }
        public static AllClassesPage goAllClassesPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("All Classes")));
            allClassesTab = driver.FindElement(By.PartialLinkText("All Classes"));
            allClassesTab.Click();
            return new AllClassesPage(driver);
        }
        public static AllClassesPage logout()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Logout"))));
            logoutButton = driver.FindElement(By.PartialLinkText("Logout"));
            logoutButton.Click();
            return new AllClassesPage(driver);
        }
        public static void quitBrowser()
        {
            driver.Quit();
        }
        public static AllClassesPage addnewClass()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Create New"))));
            newClassButton = driver.FindElement(By.PartialLinkText("Create New"));
            newClassButton.Click();
            var loading2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[14]/div/input"))));
            create_Button = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[14]/div/input"));
            create_Subject = driver.FindElement(By.Id("SubjectName"));
            SelectElement subjectDropdown = new SelectElement(create_Subject);
            subjectDropdown.SelectByIndex(0);
            create_Name = driver.FindElement(By.Id("Name"));
            create_Name.SendKeys("Afternoon automation");
            create_Section = driver.FindElement(By.Id("Section"));
            create_Section.SendKeys("101");
            create_Credits = driver.FindElement(By.Id("Credits"));
            create_Credits.SendKeys("3");
            create_Description = driver.FindElement(By.Id("Description"));
            create_Description.SendKeys("Welcome to automation!");
            create_Mon = driver.FindElement(By.Id("Mon"));
            SelectElement monDropdown = new SelectElement(create_Mon);
            monDropdown.SelectByValue("0");
            create_Tue = driver.FindElement(By.Id("Tues"));
            SelectElement tueDropdown = new SelectElement(create_Tue);
            tueDropdown.SelectByValue("0");
            create_Wed = driver.FindElement(By.Id("Wed"));
            SelectElement wedDropdown = new SelectElement(create_Wed);
            wedDropdown.SelectByValue("0");
            create_Thurs = driver.FindElement(By.Id("Thurs"));
            SelectElement thursDropdown = new SelectElement(create_Thurs);
            thursDropdown.SelectByValue("1");
            create_Fri = driver.FindElement(By.Id("Fri"));
            SelectElement friDropdown = new SelectElement(create_Fri);
            friDropdown.SelectByValue("1");
            create_StartTime = driver.FindElement(By.Id("StartTime"));
            create_StartTime.SendKeys("200PM");
            create_EndTime = driver.FindElement(By.Id("EndTime"));
            create_EndTime.SendKeys("300PM");
            create_Room = driver.FindElement(By.Id("RoomNumber"));
            create_Room.SendKeys("252");
            Thread.Sleep(2000);
            create_Button.Click();

            return new AllClassesPage(driver);
        }
        public static AllClassesPage teacherLogin()
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
            return new AllClassesPage(driver);
        }
    }
}
