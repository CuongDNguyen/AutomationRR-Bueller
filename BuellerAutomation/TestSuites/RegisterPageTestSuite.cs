using BuellerAutomation.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread.Sleep(2000);

        }
        public static void loginStudentTestCase()
        {
            RegisterPage.goBuellerWebsite();
            RegisterPage.goLoginPage();
            RegisterPage.userLogin();
        }
        public static void registerTeacherTestCase()
        {
            RegisterPage.goBuellerWebsite();
            RegisterPage.goRegisterPage();
            RegisterPage.registerNewTeacher();
            RegisterPage.registerTeacherInformation();
            Thread.Sleep(2000);
            RegisterPage.logout();
            Thread.Sleep(2000);
        }
        public static void editProfileTestCase()
        {
            RegisterPage.goProfilePage();
            RegisterPage.editUserProfile();
            Thread.Sleep(3000);
        }

        public static void differentStudentPageTestCase()
        {
            RegisterPage.goAllClassesPage();
            Thread.Sleep(3000);
            RegisterPage.goMyClassesPage();
            Thread.Sleep(3000);
            RegisterPage.goMyTeachersPage();
            Thread.Sleep(3000);
        }
        public static void teacherAddClassTestCase()
        {
            RegisterPage.goBuellerWebsite();
            RegisterPage.goLoginPage();
            RegisterPage.teacherLogin();
            RegisterPage.goAllClassesPage();
            RegisterPage.addnewClass();
        }
        public static void teacherAddAssignmentTestCase()
        {
            RegisterPage.goMyClassesPage();
            Thread.Sleep(2000);
            RegisterPage.addnewAssignment();
        }

        public static void studentEnrollTestCase()
        {
            RegisterPage.goAllClassesPage();
            Thread.Sleep(2000);
            RegisterPage.enrollClass();
            Thread.Sleep(2000);
            RegisterPage.goMyClassesPage();
            Thread.Sleep(2000);
        }

        public static void studentUnenrollTestCase()
        {
            RegisterPage.goMyClassesPage();
            Thread.Sleep(2000);
            RegisterPage.unenrollClass();
            Thread.Sleep(2000);
            RegisterPage.logout();
        }
    }
}
