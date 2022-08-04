using JobCoopCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
    public class JobRepositoryFactory
    {
        public IJobRepository Create(JobRepositoryType jobRepositoryType)
        {
            if (jobRepositoryType == JobRepositoryType.InMemoryJobRepository)
            {
                return new JobRepository(null);

            }
            else if (jobRepositoryType == JobRepositoryType.SqlJobRepository)
            {
                return new JobSqlRepository();
            }

            throw new ArgumentException("JobRepositoryType is unknown");
        }
    }
}