using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopCommon.Interfaces
{
    public interface IApplicationRepository
    {
        void Add(Application app);
        Student Get(string id);
        void Delete(string id);
        void Update(string id, Application app);
    }
}