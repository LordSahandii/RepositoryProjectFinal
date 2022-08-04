using ApplicationCoopCommon;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
    public class ApplicationRepository : IApplicationRepositoryReportable, IPrintable
    {
        private List<Application> applications = new List<Application>();

        public ApplicationRepository(List<Application> applications)
        {
            if (applications != null)
            {
                this.applications = applications;
            }
        }

        public void Add(Application student)
        {

            this.applications.Add(student);


        }

        public Application Get(string id)
        {
            var student = this.applications.Find(s => s.ID == id);
            return student;
        }

        public void Delete(string id)
        {
            var i = this.applications.IndexOf(s => s.ID == id);
            this.applications.RemoveAt(i);
        }

        public void Update(Application student)
        {

            var i = this.applications.IndexOf(s => s.ID == id);
            this.applications.Insert(index, student);
        }

        public IEnumerable<Application> Get(IEnumerable<string> filters)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}