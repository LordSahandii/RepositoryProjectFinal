using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopCommon.Interfaces
{
    public interface IJobRepository
    {
        void Add(Job job);
        Student Get(string id);
        void Delete(string id);
        void Update(string id, Job job);
    }
}