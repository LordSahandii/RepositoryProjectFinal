using CompanyCoopCommon;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
    public class CompanyRepository : ICompanyRepositoryReportable, IPrintable
    {
        private List<Company> companies = new List<Company>();

        public CompanyRepository(List<Company> companies)
        {
            if (companies != null)
            {
                this.companies = companies;
            }
        }

        public void Add(Company student)
        {

            this.companies.Add(student);


        }

        public Company Get(string id)
        {
            var student = this.companies.Find(s => s.ID == id);
            return student;
        }

        public void Delete(string id)
        {
            var i = this.companies.IndexOf(s => s.ID == id);
            this.companies.RemoveAt(i);
        }

        public void Update(Company student)
        {

            var i = this.companies.IndexOf(s => s.ID == id);
            this.companies.Insert(index, student);
        }

        public IEnumerable<Company> Get(IEnumerable<string> filters)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}