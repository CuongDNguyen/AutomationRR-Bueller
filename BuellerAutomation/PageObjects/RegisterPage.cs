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
        public static IWebElement logoutButton { get; set; }
        public static IWebElement loginTab { get; set; }
        public static IWebElement allClassesTab { get; set; }
        public static IWebElement myClassesTab { get; set; }
        public static IWebElement login_Email { get; set; }
        public static IWebElement login_Password { get; set; }
        public static IWebElement login_Button { get; set; }
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
        public static IWebElement myTeacherTab { get; set; }
        public static IWebElement register_State { get; set; }
        public static IWebElement register_Country { get; set; }
        public static IWebElement register_ZipCode { get; set; }
        public static IWebElement register_PhoneNumber { get; set; }
        public static IWebElement register_ClassLevel { get; set; }
        public static IWebElement register_InformationButton { get; set; }
        public static IWebElement register_Title {get; set;}
        public static IWebElement register_OfficeNumber { get; set; }
        public static IWebElement register_OfficePhoneNumber { get; set; }
        public static IWebElement register_ConfirmPassword { get; set; }
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
        public RegisterPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public static void goBuellerWebsite()
        {
            driver.Manage().Window.Maximize();
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
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[5]/div/input"))));
            register_Email = driver.FindElement(By.Id("Email"));
            register_Password = driver.FindElement(By.Id("Password"));
            register_Role = driver.FindElement(By.Id("role"));
            register_Button = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[5]/div/input"));
            register_Email.SendKeys("studentauto22@ruralsourcing.com");
            register_Password.SendKeys("automation123!123");
            register_ConfirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            register_ConfirmPassword.SendKeys("automation123!123");
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
        public static RegisterPage registerNewTeacher()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[5]/div/input"))));
            register_Email = driver.FindElement(By.Id("Email"));
            register_Password = driver.FindElement(By.Id("Password"));
            register_Role = driver.FindElement(By.Id("role"));
            register_Button = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[5]/div/input"));
            register_Email.SendKeys("teacher24@ruralsourcing.com");
            register_Password.SendKeys("automation123!123");
            register_ConfirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            register_ConfirmPassword.SendKeys("automation123!123");
            SelectElement roleDropDown = new SelectElement(register_Role);
            roleDropDown.SelectByText("teacher");
            Thread.Sleep(2000);
            register_Button.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage registerTeacherInformation()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[13]/div/input"))));
            register_InformationButton = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[13]/div/input"));
            register_Title = driver.FindElement(By.Id("Title"));
            register_Title.SendKeys("Professor");
            register_FirstName = driver.FindElement(By.Id("FirstName"));
            register_FirstName.SendKeys("TeacherAutomation");
            register_MiddleName = driver.FindElement(By.Id("MiddleName"));
            register_MiddleName.SendKeys("Knowledge");
            register_LastName = driver.FindElement(By.Id("LastName"));
            register_LastName.SendKeys("Instructor");
            register_OfficeNumber = driver.FindElement(By.Id("OfficeNumber"));
            register_OfficeNumber.SendKeys("41");
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
            register_PhoneNumber = driver.FindElement(By.Id("PersonalPhoneNumber"));
            register_PhoneNumber.SendKeys("(504) 819-2301");
            register_OfficePhoneNumber = driver.FindElement(By.Id("OfficePhoneNumber"));
            register_OfficePhoneNumber.SendKeys("(827) 312-4592");
            Thread.Sleep(2000);
            register_InformationButton.Click();

            return new RegisterPage(driver);
        }

        public static RegisterPage logout()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Logout"))));
            logoutButton = driver.FindElement(By.PartialLinkText("Logout"));
            logoutButton.Click();
            return new RegisterPage(driver);
        }
        public static void quitBrowser()
        {
            driver.Quit();
        }
        public static RegisterPage userLogin()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btnSubmit")));
            login_Email = driver.FindElement(By.Id("email"));
            login_Password = driver.FindElement(By.Id("Password"));
            login_Button = driver.FindElement(By.Id("btnSubmit"));
            login_Email.SendKeys("studentauto20@ruralsourcing.com");
            login_Password.SendKeys("automation123!123");
            Thread.Sleep(2000);
            login_Button.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage goLoginPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Login"))));
            loginTab = driver.FindElement(By.PartialLinkText(@"Login"));
            loginTab.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage goProfilePage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.LinkText("Profile"))));
            profileTab = driver.FindElement(By.LinkText("Profile"));
            profileTab.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage editUserProfile()
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
            return new RegisterPage(driver);
        }
        public static RegisterPage goAllClassesPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("All Classes")));
            allClassesTab = driver.FindElement(By.PartialLinkText("All Classes"));
            allClassesTab.Click();
            return new RegisterPage(driver);
        }

        public static RegisterPage goMyClassesPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("My Classes")));
            allClassesTab = driver.FindElement(By.PartialLinkText("My Classes"));
            allClassesTab.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage teacherLogin()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("btnSubmit")));
            login_Email = driver.FindElement(By.Id("email"));
            login_Password = driver.FindElement(By.Id("Password"));
            login_Button = driver.FindElement(By.Id("btnSubmit"));
            login_Email.SendKeys("teacher19@ruralsourcing.com");
            login_Password.SendKeys("automation123!123");
            Thread.Sleep(2000);
            login_Button.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage goMyTeachersPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.PartialLinkText("My Teachers")));
            myTeacherTab = driver.FindElement(By.PartialLinkText("My Teachers"));
            myTeacherTab.Click();
            Thread.Sleep(2000);
            return new RegisterPage(driver);
        }
        public static RegisterPage addnewClass()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Create New"))));
            newClassButton = driver.FindElement(By.PartialLinkText("Create New"));
            newClassButton.Click();
            var loading2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div[2]/form/div/div[11]/div/input"))));
            create_Button = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[11]/div/input"));
            create_Subject = driver.FindElement(By.Id("SelectSubject"));
            SelectElement subjectDropdown = new SelectElement(create_Subject);
            subjectDropdown.SelectByValue("Add Subject");
            IWebElement newSubject = driver.FindElement(By.Id("NewSubject"));
            newSubject.SendKeys("Mysteries");
            create_Name = driver.FindElement(By.Id("Name"));
            create_Name.SendKeys("Afternoon automation");
            create_Section = driver.FindElement(By.Id("Section"));
            create_Section.SendKeys("101");
            create_Credits = driver.FindElement(By.Id("Credits"));
            create_Credits.SendKeys("3");
            create_Description = driver.FindElement(By.Id("Description"));
            create_Description.SendKeys("Welcome to automation!");
            create_Mon = driver.FindElement(By.Id("Monday"));
            create_Tue = driver.FindElement(By.Id("Tuesday"));
            create_Wed = driver.FindElement(By.Id("Wednesday"));
            create_Wed.Click();
            create_Thurs = driver.FindElement(By.Id("Thursday"));
            create_Thurs.Click();
            create_Fri = driver.FindElement(By.Id("Friday"));
            create_Fri.Click();
            create_StartTime = driver.FindElement(By.Id("StartTime"));
            create_StartTime.SendKeys("200PM");
            create_EndTime = driver.FindElement(By.Id("EndTime"));
            create_EndTime.SendKeys("300PM");
            create_Room = driver.FindElement(By.Id("RoomNumber"));
            create_Room.SendKeys("252");
            Thread.Sleep(2000);
            create_Button.Click();

            return new RegisterPage(driver);
        }
        public static RegisterPage enrollClass()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Enroll"))));
            IWebElement enrollButton = driver.FindElement(By.PartialLinkText("Enroll"));
            enrollButton.Click();
            Thread.Sleep(2000);
            var loading2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Enroll"))));
            IWebElement enrollButton2nd = driver.FindElement(By.PartialLinkText("Enroll"));
            enrollButton2nd.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage unenrollClass()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Unenroll"))));
            IWebElement UnenrollButton = driver.FindElement(By.PartialLinkText("Unenroll"));
            UnenrollButton.Click();
            Thread.Sleep(2000);
            var loading2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Unenroll"))));
            IWebElement UnenrollButton2nd = driver.FindElement(By.PartialLinkText("Unenroll"));
            UnenrollButton2nd.Click();
            return new RegisterPage(driver);
        }
        public static RegisterPage addnewAssignment()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Assignments"))));
            IWebElement AssignmentsButton = driver.FindElement(By.PartialLinkText("Assignments"));
            AssignmentsButton.Click();
            var loading2 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.PartialLinkText("Create Assignment"))));
            IWebElement AssignmentsButton2 = driver.FindElement(By.PartialLinkText("Create Assignment"));
            AssignmentsButton2.Click();
            IWebElement AssignmentName = driver.FindElement(By.Id("Name"));
            AssignmentName.SendKeys("AutomatedAssignment");
            IWebElement EvaluationType = driver.FindElement(By.Id("EvaluationType"));
            EvaluationType.SendKeys("Online");
            IWebElement submitAssignmentButton = driver.FindElement(By.XPath("/html/body/div[2]/form/div/div[4]/div/input"));
            Thread.Sleep(2000);
            submitAssignmentButton.Click();
            return new RegisterPage(driver);
        }

    }
}
