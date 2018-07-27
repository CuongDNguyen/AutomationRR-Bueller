using BuellerAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuellerAutomation.TestSuites
{
    class MyTeachersPageTestSuite
    {
       public static void viewTeachersPageTestCase ()
        {
            MyTeachersPage.goBuellerWebsite();
            MyTeachersPage.goLoginPage();
            MyTeachersPage.userLogin();
            MyTeachersPage.goMyTeachersPage();
            MyTeachersPage.logout();
        }
    }
}
