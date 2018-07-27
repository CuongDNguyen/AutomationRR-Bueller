using BuellerAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuellerAutomation.TestSuites
{
    class RegisterPageTestSuite
    {
        public static void registerStudentTestCase()
        {
            RegisterPage.goBuellerWebsite();
            RegisterPage.goRegisterPage();
            RegisterPage.registerNewStudent();
            RegisterPage.registerNewFreshman();
            RegisterPage.logout();
        }
        public static void registerTeacherTestCase()
        {
            RegisterPage.goBuellerWebsite();
            RegisterPage.goRegisterPage();
            RegisterPage.registerNewTeacher();
            RegisterPage.registerTeacherInformation();
        }
    }
}
