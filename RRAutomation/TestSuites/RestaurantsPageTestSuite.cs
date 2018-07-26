using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestaurantReviewsAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantReviewsAutomation.TestSuites
{
    public class RestaurantsPageTestSuite
    {
        public static void CreateRestaurantsTestCase()
        {
            RestaurantsPage.goWebsite();
            RestaurantsPage.goToRestaurantPage();
            RestaurantsPage.addRestaurant();
            RestaurantsPage.createMcDonalds();
            RestaurantsPage.addRestaurant();
            RestaurantsPage.createWendies();
            RestaurantsPage.addRestaurant();
            RestaurantsPage.createKfc();
            RestaurantsPage.addRestaurant();
            RestaurantsPage.createBurgerKing();
            RestaurantsPage.addRestaurant();
            RestaurantsPage.createIHOP();
            RestaurantsPage.addRestaurant();
            RestaurantsPage.createWaffleHouse();
            RestaurantsPage.quitBrowser();
        }

        public static void SortByTestCase()
        {
            RestaurantsPage.goWebsite();
            RestaurantsPage.goToRestaurantPage();
            RestaurantsPage.sortByName();
            RestaurantsPage.sortByOthers();
            RestaurantsPage.quitBrowser();
        }

        public static void AddReviewsTestCase()
        {
            RestaurantsPage.goWebsite();
            RestaurantsPage.goToRestaurantPage();
            RestaurantsPage.addReviews();
            RestaurantsPage.quitBrowser();
        }
        public static void EditReviewsTestCase()
        {

        }
        public static void EditRestaurantsTestCase()
        {
            RestaurantsPage.goWebsite();
            RestaurantsPage.goToRestaurantPage();
            RestaurantsPage.editRestaurants();
            RestaurantsPage.quitBrowser();
        }
        public static void DeleteRestaurantsTestCase()
        {
            RestaurantsPage.goWebsite();
            RestaurantsPage.goToRestaurantPage();
            RestaurantsPage.deleteRestaurants();
            RestaurantsPage.deleteRestaurants();
            RestaurantsPage.deleteRestaurants();
            RestaurantsPage.quitBrowser();
        }
        public static void SearchRestaurantsTestCase()
        {
            RestaurantsPage.goWebsite();
            RestaurantsPage.goToRestaurantPage();
            RestaurantsPage.search();
            RestaurantsPage.quitBrowser();
        }
    }
}