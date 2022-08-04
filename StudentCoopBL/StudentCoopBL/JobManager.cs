using StudentCoopCommon;
using StudentCoopCommon.Interfaces;
using StudentCoopDal;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopBL
{
    public class JobManager
    {
        private readonly IJobRepository jobRepository;
        private readonly ILogger logger;

        public StudentManager(IJobRepository jobRepository, ILogger logger)
        {
            this.jobRepository = jobRepository;
            this.logger = logger;
        }

        public void Add(Job job)
        {
            this.jobRepository.Add(job);
        }

        public Job Get(string id)
        {
            this.logger.Log($"studentManager get id:{id}");
            var job = this.JobRepository.Get(id);

            if (job != null)
            {
                this.logger.Log($"JobManager get id:{job.ID} name:{job.Title}");
            }

            return job;
        }
        public Job Delete(string id)
        {
            this.logger.Log($"JobManager get id:{id}");
            var job = this.jobRepository.Get(id);

            if (job != null)
            {
                this.jobRepository.Delete(id);
            }

            return job;
        }
        public Job Update(string id, Job job)
        {
            this.logger.Log($"jobManager get id:{id}");
            var job = this.jobRepository.Get(id);

            if (job != null)
            {
                this.jobRepository.Update(id, job);
            }

            return job;
        }
    }
}