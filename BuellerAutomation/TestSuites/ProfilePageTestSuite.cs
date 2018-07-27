using BuellerAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuellerAutomation.TestSuites
{
    class ProfilePageTestSuite
    {
        public static void userLoginTestCase()
        {
            ProfilePage.goBuellerWebsite();
            ProfilePage.goLoginPage();
            ProfilePage.userLogin();
            ProfilePage.logout();
        }
        public static void editProfileTestCase()
        {
            ProfilePage.goBuellerWebsite();
            ProfilePage.goLoginPage();
            ProfilePage.userLogin();
            ProfilePage.goProfilePage();
            ProfilePage.editUserProfile();
            ProfilePage.logout();
        }
    }
}
