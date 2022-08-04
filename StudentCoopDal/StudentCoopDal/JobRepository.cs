using JobCoopCommon;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
    public class JobRepository : IJobRepositoryReportable, IPrintable
    {
        private List<Job> jobs = new List<Job>();

        public JobRepository(List<Job> jobs)
        {
            if (jobs != null)
            {
                this.jobs = jobs;
            }
        }

        public void Add(Job student)
        {

            this.jobs.Add(student);


        }

        public Job Get(string id)
        {
            var student = this.jobs.Find(s => s.ID == id);
            return student;
        }

        public void Delete(string id)
        {
            var i = this.jobs.IndexOf(s => s.ID == id);
            this.jobs.RemoveAt(i);
        }

        public void Update(Job student)
        {

            var i = this.jobs.IndexOf(s => s.ID == id);
            this.jobs.Insert(index, student);
        }

        public IEnumerable<Job> Get(IEnumerable<string> filters)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}