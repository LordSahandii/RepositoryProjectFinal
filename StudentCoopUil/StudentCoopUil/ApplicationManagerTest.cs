using StudentCoopBL;
using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using StudentCoopCommon.Logging;
using StudentCoopDal;
using System;

namespace StudentCoopApp
{
    class ApplicationManagerTest
    {
        private ILogger logger;
        private ApplicationManager applicationManager;
        private readonly ApplicationRepositoryFactory studentRepositoryFactory = new ApplicationRepositoryFactory();
        private const string defaultApplicationId = "testId";
        private const string defaultApplicationName = "testName";

        public void Get_WhenApplicationIsAdded_ShouldBeAbleToGet()
        {
            // Preparation 
            this.InitializeTest();
            var expectedApplication = this.GetApplicationObject();
            this.applicationManager.Add(expectedApplication);

            // Test
            var application = this.applicationManager.Get(defaultApplicationId);

            // Validation of Results
            var isValid = application.ID == defaultApplicationId && student.Name == defaultApplicationName;
            if (!isValid)
            {
                throw new Exception("Add test failed");
            }
        }

        public void Get_WhenApplicationDoesNotExist_ShouldReturnNull()
        {
            // Preparation for the test 
            this.InitializeTest();

            // Test
            var application = applicationManager.Get("9877");

            // Validation of results
            var isValid = application == null;
            if (!isValid)
            {
                throw new Exception("Get when student does not exist failed");
            }
        }

        private void InitializeTest()
        {
            this.logger = new FileLogger();
            this.applicationManager = new ApplicationManager(
                applicationRepositoryFactory.Create(ApplicationRepositoryType.InMemoryStudentRepository),
                logger);
        }

        private Application GetStudentObject(string id = defaultApplicationId, string Name = defaultApplicationName)
        {
            return new Application() { ID = id, Name = defaultApplicationName };
        }
    }
}