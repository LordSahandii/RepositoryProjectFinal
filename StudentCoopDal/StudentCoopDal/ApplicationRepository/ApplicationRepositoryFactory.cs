using ApplicationCoopCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
    public class ApplicationRepositoryFactory
    {
        public IApplicationRepository Create(ApplicationRepositoryType applicationRepositoryType)
        {
            if (applicationRepositoryType == ApplicationRepositoryType.InMemoryApplicationRepository)
            {
                return new ApplicationRepository(null);

            }
            else if (applicationRepositoryType == ApplicationRepositoryType.SqlApplicationRepository)
            {
                return new ApplicationSqlRepository();
            }

            throw new ArgumentException("ApplicationRepositoryType is unknown");
        }
    }
}