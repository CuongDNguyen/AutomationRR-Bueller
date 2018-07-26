using RestaurantReviewsAutomation.TestSuites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
           RestaurantsPageTestSuite.CreateRestaurantsTestCase();
           RestaurantsPageTestSuite.AddReviewsTestCase();
           RestaurantsPageTestSuite.SortByTestCase();
           RestaurantsPageTestSuite.SearchRestaurantsTestCase();
           RestaurantsPageTestSuite.EditRestaurantsTestCase();
           RestaurantsPageTestSuite.DeleteRestaurantsTestCase();
        }
    }
}
