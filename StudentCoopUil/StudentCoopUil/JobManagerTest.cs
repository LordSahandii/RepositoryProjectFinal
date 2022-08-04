using StudentCoopBL;
using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using StudentCoopCommon.Logging;
using StudentCoopDal;
using System;

namespace StudentCoopApp
{
    class JobManagerTest
    {
        private ILogger logger;
        private JobManager jobManager;
        private readonly JobRepositoryFactory jobRepositoryFactory = new JobRepositoryFactory();
        private const string defaultJobId = "testId";
        private const string defaultJobTitle = "testTitle";

        public void Get_WhenJobIsAdded_ShouldBeAbleToGet()
        {
            // Preparation 
            this.InitializeTest();
            var expectedJob = this.GetJobObject();
            this.jobManager.Add(expectedJob);

            // Test
            var job = this.jobManager.Get(defaultJobId);

            // Validation of Results
            var isValid = job.ID == defaultJobId && student.Title == defaultJobTitle;
            if (!isValid)
            {
                throw new Exception("Add test failed");
            }
        }

        public void Get_WhenJobDoesNotExist_ShouldReturnNull()
        {
            // Preparation for the test 
            this.InitializeTest();

            // Test
            var job = jobManager.Get("9877");

            // Validation of results
            var isValid = job == null;
            if (!isValid)
            {
                throw new Exception("Get when student does not exist failed");
            }
        }

        private void InitializeTest()
        {
            this.logger = new FileLogger();
            this.jobManager = new JobManager(
                jobRepositoryFactory.Create(JobRepositoryType.InMemoryStudentRepository),
                logger);
        }

        private Job GetJobObject(string id = defaultJobId, string Title = defaultJobTitle)
        {
            return new Job() { ID = id, Title = defaultJobTitle };
        }
    }
}