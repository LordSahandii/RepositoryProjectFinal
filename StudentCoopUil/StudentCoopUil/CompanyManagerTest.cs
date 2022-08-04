using StudentCoopBL;
using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using StudentCoopCommon.Logging;
using StudentCoopDal;
using System;

namespace StudentCoopApp
{
    class CompanyManagerTest
    {
        private ILogger logger;
        private CompanyManager companyManager;
        private readonly CompanyRepositoryFactory companyRepositoryFactory = new CompanyRepositoryFactory();
        private const string defaultCompanyId = "testId";
        private const string defaultCompanyFName = "testName";

        public void Get_WhenCompanyIsAdded_ShouldBeAbleToGet()
        {
            // Preparation 
            this.InitializeTest();
            var expectedCompany = this.GetStudentObject();
            this.companyManager.Add(expectedCompany);

            // Test
            var company = this.companyManager.Get(defaultCompanyId);

            // Validation of Results
            var isValid = company.ID == defaultCompanyId && company.Name == defaultCompanyName;
            if (!isValid)
            {
                throw new Exception("Add test failed");
            }
        }

        public void Get_WhenCompanyDoesNotExist_ShouldReturnNull()
        {
            // Preparation for the test 
            this.InitializeTest();

            // Test
            var company = companyManager.Get("9877");

            // Validation of results
            var isValid = company == null;
            if (!isValid)
            {
                throw new Exception("Get when student does not exist failed");
            }
        }

        private void InitializeTest()
        {
            this.logger = new FileLogger();
            this.companyManager = new CompanyManager(
                companyRepositoryFactory.Create(CompanyRepositoryType.InMemoryCompanyRepository),
                logger);
        }

        private Company GetCompanyObject(string id = defaultCompanyId, string Name = defaultCompanyName)
        {
            return new Company() { ID = id, Name = defaultCompanyName };
        }
    }
}