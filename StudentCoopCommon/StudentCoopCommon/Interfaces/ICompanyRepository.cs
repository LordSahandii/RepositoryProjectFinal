using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopCommon.Interfaces
{
    public interface ICompanyRepository
    {
        void Add(Company company);
        Student Get(string id);
        void Delete(string id);
        void Update(string id,Company company);
    }
}