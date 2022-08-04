using StudentCoopBL;
using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using StudentCoopCommon.Logging;
using StudentCoopDal;
using System;

namespace StudentCoopApp
{
    class StudentManagerTest
    {
        private ILogger logger;
        private StudentManager studentManager;
        private readonly StudentRepositoryFactory studentRepositoryFactory = new StudentRepositoryFactory();
        private const string defaultStudentId = "testId";
        private const string defaultStudentFName = "testFName";

        public void Get_WhenStudentIsAdded_ShouldBeAbleToGet()
        {
            // Preparation 
            this.InitializeTest();
            var expectedStudent = this.GetStudentObject();
            this.studentManager.Add(expectedStudent);

            // Test
            var student = this.studentManager.Get(defaultStudentId);

            // Validation of Results
            var isValid = student.ID == defaultStudentId && student.FirstName == defaultStudentFName;
            if (!isValid)
            {
                throw new Exception("Add test failed");
            }
        }

        public void Get_WhenStudentDoesNotExist_ShouldReturnNull()
        {
            // Preparation for the test 
            this.InitializeTest();

            // Test
            var student = studentManager.Get("9877");

            // Validation of results
            var isValid = student == null;
            if (!isValid)
            {
                throw new Exception("Get when student does not exist failed");
            }
        }

        private void InitializeTest()
        {
            this.logger = new FileLogger();
            this.studentManager = new StudentManager(
                studentRepositoryFactory.Create(StudentRepositoryType.InMemoryStudentRepository),
                logger);
        }

        private Student GetStudentObject(string id = defaultStudentId, string firstName = defaultStudentFName)
        {
            return new Student() { ID = id, FirstName = defaultStudentFName };
        }
    }
}