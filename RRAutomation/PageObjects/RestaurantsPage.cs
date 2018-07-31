using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace RestaurantReviewsAutomation.PageObjects
{
    public class RestaurantsPage
    {
        public static string RestaurantWebsite = "localhost:61741";
        public IWebDriver _driver;
        private static IWebDriver driver = new ChromeDriver(@SystemElements.chromeDriverPath);


        public static IWebElement Restaurants { get; set; }
        public static IWebElement AddRestaurantButton { get; set; }
        public static IWebElement create_Name { get; set; }
        public static IWebElement create_Street { get; set; }
        public static IWebElement create_City { get; set; }
        public static IWebElement create_State { get; set; }
        public static IWebElement create_Country { get; set; }
        public static IWebElement create_Zipcode { get; set; }
        public static IWebElement create_Phone { get; set; }
        public static IWebElement create_Website { get; set; }
        public static IWebElement create_Button { get; set; }
        public static IWebElement edit_Name { get; set; }
        public static IWebElement edit_Street { get; set; }
        public static IWebElement edit_City { get; set; }
        public static IWebElement edit_State { get; set; }
        public static IWebElement edit_Country { get; set; }
        public static IWebElement edit_Zipcode { get; set; }
        public static IWebElement edit_Phone { get; set; }
        public static IWebElement edit_Website { get; set; }
        public static IWebElement edit_Button { get; set; }
        public static IWebElement sortby_NameAscending { get; set; }
        public static IWebElement sortby_NameDescending { get; set; }
        public static IWebElement sortby_HighestRated { get; set; }
        public static IWebElement sortby_MostReviewed { get; set; }
        public static IWebElement reviewRestaurant { get; set; }
        public static IWebElement addReviewButton { get; set; }
        public static IWebElement review_Rating { get; set; }
        public static IWebElement review_User { get; set; }
        public static IWebElement review_Comment { get; set; }
        public static IWebElement review_Button { get; set; }
        public static IWebElement editRestaurant { get; set; }
        public static IWebElement deleteRestaurant { get; set; }
        public static IWebElement delete_Button { get; set; }
        public static IWebElement searchBar { get; set; }
        public static IWebElement searchButton { get; set; }
        public static IWebElement clearButton { get; set; }

        public RestaurantsPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public static void goWebsite()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments(new List<string> {
                "--start-maximized"});
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(RestaurantWebsite);
        }
        public static RestaurantsPage goToRestaurantPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.LinkText("Restaurants"))));
            Restaurants = driver.FindElement(By.LinkText("Restaurants"));
            Thread.Sleep(2000);
            Restaurants.Click();
            return new RestaurantsPage(driver);
        }

        public static RestaurantsPage addRestaurant()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/div[1]/div[1]/a"))));
            AddRestaurantButton = driver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/a"));
            Thread.Sleep(2000);
            AddRestaurantButton.Click();
            return new RestaurantsPage(driver);
        }

        public static RestaurantsPage createMcDonalds()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/form/div/div[9]/div/input"))));
            create_Name = driver.FindElement(By.Id("Name"));
            create_Street = driver.FindElement(By.Id("Street"));
            create_City = driver.FindElement(By.Id("City"));
            create_State = driver.FindElement(By.Id("State"));
            create_Country = driver.FindElement(By.Id("Country"));
            create_Zipcode = driver.FindElement(By.Id("Zipcode"));
            create_Phone = driver.FindElement(By.Id("Phone"));
            create_Website = driver.FindElement(By.Id("Website"));
            create_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
            create_Name.SendKeys("McDonalds");
            create_Street.SendKeys("723 Silver AVE NW");
            create_City.SendKeys("Albuquerque");
            create_State.SendKeys("New Mexico");
            create_Country.SendKeys("United States");
            create_Zipcode.SendKeys("87120");
            create_Phone.SendKeys("(505) 218-8500");
            create_Website.SendKeys("https://www.McDonalds.Com");
            Thread.Sleep(2000);
            create_Button.Click();
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage createWendies()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/form/div/div[9]/div/input"))));
            create_Name = driver.FindElement(By.Id("Name"));
            create_Street = driver.FindElement(By.Id("Street"));
            create_City = driver.FindElement(By.Id("City"));
            create_State = driver.FindElement(By.Id("State"));
            create_Country = driver.FindElement(By.Id("Country"));
            create_Zipcode = driver.FindElement(By.Id("Zipcode"));
            create_Phone = driver.FindElement(By.Id("Phone"));
            create_Website = driver.FindElement(By.Id("Website"));
            create_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
            create_Name.SendKeys("Wendy's");
            create_Street.SendKeys("455 St. Louis St");
            create_City.SendKeys("Mobile");
            create_State.SendKeys("Alabama");
            create_Country.SendKeys("United States");
            create_Zipcode.SendKeys("36602");
            create_Phone.SendKeys("(251) 544-9620");
            create_Website.SendKeys("https://www.Wendys.Com");
            Thread.Sleep(2000);
            create_Button.Click();
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage createKfc()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/form/div/div[9]/div/input"))));
            create_Name = driver.FindElement(By.Id("Name"));
            create_Street = driver.FindElement(By.Id("Street"));
            create_City = driver.FindElement(By.Id("City"));
            create_State = driver.FindElement(By.Id("State"));
            create_Country = driver.FindElement(By.Id("Country"));
            create_Zipcode = driver.FindElement(By.Id("Zipcode"));
            create_Phone = driver.FindElement(By.Id("Phone"));
            create_Website = driver.FindElement(By.Id("Website"));
            create_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
            create_Name.SendKeys("KFC");
            create_Street.SendKeys("411 Union St");
            create_City.SendKeys("Jonesboro");
            create_State.SendKeys("Arkansas");
            create_Country.SendKeys("United States");
            create_Zipcode.SendKeys("72401");
            create_Phone.SendKeys("(870) 206-9300");
            create_Website.SendKeys("https://www.KFC.Com");
            Thread.Sleep(2000);
            create_Button.Click();
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage createBurgerKing()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/form/div/div[9]/div/input"))));
            create_Name = driver.FindElement(By.Id("Name"));
            create_Street = driver.FindElement(By.Id("Street"));
            create_City = driver.FindElement(By.Id("City"));
            create_State = driver.FindElement(By.Id("State"));
            create_Country = driver.FindElement(By.Id("Country"));
            create_Zipcode = driver.FindElement(By.Id("Zipcode"));
            create_Phone = driver.FindElement(By.Id("Phone"));
            create_Website = driver.FindElement(By.Id("Website"));
            create_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
            create_Name.SendKeys("Burger King");
            create_Street.SendKeys("1450 Greene St");
            create_City.SendKeys("Augusta");
            create_State.SendKeys("Georgia");
            create_Country.SendKeys("United States");
            create_Zipcode.SendKeys("30912");
            create_Phone.SendKeys("(706) 250-5400");
            create_Website.SendKeys("https://www.burgerking.Com");
            create_Button.Click();
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage createIHOP()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/form/div/div[9]/div/input"))));
            create_Name = driver.FindElement(By.Id("Name"));
            create_Street = driver.FindElement(By.Id("Street"));
            create_City = driver.FindElement(By.Id("City"));
            create_State = driver.FindElement(By.Id("State"));
            create_Country = driver.FindElement(By.Id("Country"));
            create_Zipcode = driver.FindElement(By.Id("Zipcode"));
            create_Phone = driver.FindElement(By.Id("Phone"));
            create_Website = driver.FindElement(By.Id("Website"));
            create_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
            create_Name.SendKeys("IHOP");
            create_Street.SendKeys("385 Atlantic Ocean");
            create_City.SendKeys("Atlanta");
            create_State.SendKeys("Georgia");
            create_Country.SendKeys("United States");
            create_Zipcode.SendKeys("32712");
            create_Phone.SendKeys("(437) 543-4321");
            create_Website.SendKeys("https://www.ihop.Com");
            create_Button.Click();
            return new RestaurantsPage(driver);
        }

        public static RestaurantsPage createWaffleHouse()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/div/form/div/div[9]/div/input"))));
            create_Name = driver.FindElement(By.Id("Name"));
            create_Street = driver.FindElement(By.Id("Street"));
            create_City = driver.FindElement(By.Id("City"));
            create_State = driver.FindElement(By.Id("State"));
            create_Country = driver.FindElement(By.Id("Country"));
            create_Zipcode = driver.FindElement(By.Id("Zipcode"));
            create_Phone = driver.FindElement(By.Id("Phone"));
            create_Website = driver.FindElement(By.Id("Website"));
            create_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
            create_Name.SendKeys("Waffle House");
            create_Street.SendKeys("235 Waffle Dr");
            create_City.SendKeys("Houston");
            create_State.SendKeys("Texas");
            create_Country.SendKeys("United States");
            create_Zipcode.SendKeys("55879");
            create_Phone.SendKeys("(437) 543-4321");
            create_Website.SendKeys("https://www.wafflehouse.Com");
            create_Button.Click();
            return new RestaurantsPage(driver);
        }

        public static RestaurantsPage sortByName()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.LinkText("Name (Ascending)"))));
            Thread.Sleep(2000);
            sortby_NameDescending = driver.FindElement(By.LinkText("Name (Descending)"));
            sortby_NameDescending.Click();
            Thread.Sleep(2000);
            sortby_NameAscending = driver.FindElement(By.LinkText("Name (Ascending)"));
            sortby_NameAscending.Click();
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage sortByOthers()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.LinkText("Name (Ascending)"))));
            sortby_HighestRated = driver.FindElement(By.LinkText("Highest Rated"));
            sortby_HighestRated.Click();
            Thread.Sleep(2000);
            sortby_MostReviewed = driver.FindElement(By.LinkText("Most Reviewed"));
            sortby_MostReviewed.Click();
            Thread.Sleep(2000);
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage addReviews()
        {
            var position = 1;
            bool isElementDisplayed = true;
            while (isElementDisplayed == true)
            {
                var tempPath = "/html/body/div/div[2]/div[" + position + "]/div/div[2]/div/h6/a[1]";
                if (driver.FindElements(By.XPath(tempPath)).Count == 0)
                {
                    isElementDisplayed = false;
                    break;
                }
                
                reviewRestaurant = driver.FindElement(By.XPath(tempPath));
                reviewRestaurant.Click();
                position = position + 1;
                addReviewButton = driver.FindElement(By.XPath("/html/body/div/div/div/a[1]"));
                addReviewButton.Click();
                review_Rating = driver.FindElement(By.Id("Rating"));
                review_User = driver.FindElement(By.Id("User"));
                review_Comment = driver.FindElement(By.Id("Comment"));
                review_Rating.SendKeys("10");
                review_User.SendKeys("FastFoodLover");
                review_Comment.SendKeys("I love fastfood");
                review_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[4]/div/input"));
                review_Button.Click();
                Thread.Sleep(1000);
                goToRestaurantPage();
            }
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage editRestaurants()
        {
            var position = 1;
            bool isElementDisplayed = true;
            while (isElementDisplayed == true)
            {
                var tempPath = "/html/body/div/div[2]/div[" + position + "]/div/div[2]/div/h6/a[2]";
                if (driver.FindElements(By.XPath(tempPath)).Count == 0)
                {
                    isElementDisplayed = false;
                    break;
                }

                editRestaurant = driver.FindElement(By.XPath(tempPath));
                editRestaurant.Click();
                position = position + 1;
                edit_Name = driver.FindElement(By.Id("Name"));
                edit_Street = driver.FindElement(By.Id("Street"));
                edit_City = driver.FindElement(By.Id("City"));
                edit_State = driver.FindElement(By.Id("State"));
                edit_Country = driver.FindElement(By.Id("Country"));
                edit_Zipcode = driver.FindElement(By.Id("Zipcode"));
                edit_Phone = driver.FindElement(By.Id("Phone"));
                edit_Website = driver.FindElement(By.Id("Website"));
                edit_Button = driver.FindElement(By.XPath("/html/body/div/form/div/div[9]/div/input"));
                edit_Name.Clear();
                edit_Name.SendKeys("Bojangles");
                edit_Street.Clear();
                edit_Street.SendKeys("150 Bojangles St");
                edit_City.Clear();
                edit_City.SendKeys("FastFood");
                edit_State.Clear();
                edit_State.SendKeys("Heaven");
                edit_Country.Clear();
                edit_Country.SendKeys("United States");
                edit_Zipcode.Clear();
                edit_Zipcode.SendKeys("55879");
                edit_Phone.Clear();
                edit_Phone.SendKeys("(437) 543-4321");
                edit_Website.Clear();
                edit_Website.SendKeys("https://www.bojangles.Com");
                edit_Button.Click();
                goToRestaurantPage();
            }
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage deleteRestaurants()
        {
            var position = 1;
            bool isElementDisplayed = true;
            while (isElementDisplayed == true)
            {
                var tempPath = "/html/body/div/div[2]/div[" + position + "]/div/div[2]/div/h6/a[3]";
                if (driver.FindElements(By.XPath(tempPath)).Count == 0)
                {
                    isElementDisplayed = false;
                    break;
                }
                deleteRestaurant = driver.FindElement(By.XPath(tempPath));
                deleteRestaurant.Click();
                position = position + 1;
                Thread.Sleep(1000);
                delete_Button = driver.FindElement(By.XPath("/html/body/div/div/form/div/input"));
                delete_Button.Click();
                goToRestaurantPage();
            }
            return new RestaurantsPage(driver);
        }
        public static RestaurantsPage search()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var loading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.Name("q"))));
            searchBar = driver.FindElement(By.Name("q"));
            searchBar.SendKeys("Albuquerque");
            searchButton = driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/form/input[3]"));
            searchButton.Click();
            Thread.Sleep(2000);
            clearButton = driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/form/a"));
            clearButton.Click();
            Thread.Sleep(2000);
            return new RestaurantsPage(driver);
        }
        public static void quitBrowser()
        {
            driver.Quit();
        }
    }
}