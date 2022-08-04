using CompanyCoopCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
    public class CompanyRepositoryFactory
    {
        public ICompanyRepository Create(CompanyRepositoryType companyRepositoryType)
        {
            if (companyRepositoryType == CompanyRepositoryType.InMemoryCompanyRepository)
            {
                return new CompanyRepository(null);

            }
            else if (companyRepositoryType == CompanyRepositoryType.SqlCompanyRepository)
            {
                return new CompanySqlRepository();
            }

            throw new ArgumentException("CompanyRepositoryType is unknown");
        }
    }
}