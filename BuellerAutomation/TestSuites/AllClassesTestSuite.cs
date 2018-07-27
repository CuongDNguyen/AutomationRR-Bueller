using BuellerAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuellerAutomation.TestSuites
{
    class AllClassesTestSuite
    {
        public static void addnewClassTestCase()
        {
            AllClassesPage.goBuellerWebsite();
            AllClassesPage.goLoginPage();
            AllClassesPage.teacherLogin();
            AllClassesPage.goAllClassesPage();
            AllClassesPage.addnewClass();
        }
    }
}
