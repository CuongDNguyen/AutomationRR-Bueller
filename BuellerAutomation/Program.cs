using BuellerAutomation.TestSuites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuellerAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterPageTestSuite.registerStudentTestCase();
            RegisterPageTestSuite.loginStudentTestCase();
            RegisterPageTestSuite.editProfileTestCase();
            RegisterPageTestSuite.differentStudentPageTestCase();
            RegisterPageTestSuite.studentEnrollTestCase();
            RegisterPageTestSuite.studentUnenrollTestCase();
            RegisterPageTestSuite.registerTeacherTestCase();
            RegisterPageTestSuite.teacherAddClassTestCase();
            RegisterPageTestSuite.teacherAddAssignmentTestCase();
        }
    }
}
