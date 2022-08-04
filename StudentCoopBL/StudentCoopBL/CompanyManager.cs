using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using StudentCoopDal;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopBL
{
    public class CompanyManager
    {
        private readonly ICompanyRepository companyRepository;
        private readonly ILogger logger;

        public CopmanyManager(ICompanyRepository companyRepository, ILogger logger)
        {
            this.companyRepository = companyRepository;
            this.logger = logger;
        }

        public void Add(Company company)
        {
            this.companyRepository.Add(company);
        }

        public Company Get(string id)
        {
            this.logger.Log($" get id:{id}");
            var copmany = this.companyRepository.Get(id);

            if (company != null)
            {
                this.logger.Log($" get id:{company.ID} name:{copmany.Name}");
            }

            return company;
        }
        public Company Delete(string id)
        {
            this.logger.Log($" get id:{id}");
            var company = this.companyRepository.Get(id);

            if (company != null)
            {
                this.companyRepository.Delete(id);
            }

            return company;
        }
        public Company Update(string id, Company company)
        {
            this.logger.Log($" get id:{id}");
            var company = this.companyRepository.Get(id);

            if (company != null)
            {
                this.companyRepository.Update(id, company);
            }

            return company;
        }
    }
}