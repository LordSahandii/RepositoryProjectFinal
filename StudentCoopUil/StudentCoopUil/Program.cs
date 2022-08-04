using StudentCoopApp;
using StudentCoopBL;

using StudentCoopCommon;
using StudentCoopCommon.Abstracts;
using StudentCoopCommon.Interfaces;
using StudentCoopCommon.Logging;
using StudentCoopDal;
using System;

namespace StudentCoopUil
{
    class Program
    {
        private StudentRepositoryFactory studentRepositoryFactory = new StudentRepositoryFactory();
        static void Main(string[] args)
        {
            var studentManagerTest = new StudentManagerTest();
            studentManagerTest.Get_WhenStudentIsAdded_ShouldBeAbleToGet();
            studentManagerTest.Get_WhenStudentDoesNotExist_ShouldReturnNull();

            var JobManagerTest = new JobManagerTest();
            JobManagerTest.Get_WhenJobIsAdded_ShouldBeAbleToGet();
            JobManagerTest.Get_WhenJobDoesNotExist_ShouldReturnNull();

            var CompanyManagerTest = new CompanyManagerTest();
            CompanyManagerTest.Get_WhenCompanyIsAdded_ShouldBeAbleToGet();
            CompanyManagerTest.Get_WhenCompanyDoesNotExist_ShouldReturnNull();

            var ApplicationManagerTest = new ApplicationManagerTest();
            ApplicationManagerTest.Get_WhenApplicationIsAdded_ShouldBeAbleToGet();
            ApplicationManagerTest.Get_WhenApplicationDoesNotExist_ShouldReturnNull();
        }
    }
}