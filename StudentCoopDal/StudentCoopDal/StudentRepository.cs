using StudentCoopCommon;

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCoopDal
{
     public class StudentRepository : IStudentRepositoryReportable, IPrintable
    {
        private List<Student> students = new List<Student>();

        public StudentRepository(List<Student> students)
        {
            if (students != null)
            {
                this.students = students;
            }
        }

        public void Add(Student student)
        {
            
            this.students.Add(student);

            
        }

        public Student Get(string id)
        {
            var student = this.students.Find(s => s.ID == id);
            return student;
        }

        public void Delete(string id)
        {
            var i = this.students.IndexOf(s => s.ID == id);
            this.students.RemoveAt(i);
        }

        public void Update(Student student)
        {
            
            var i = this.students.IndexOf(s => s.ID == id);
            this.students.Insert(index, student);
        }

        public IEnumerable<Student> Get(IEnumerable<string> filters)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}