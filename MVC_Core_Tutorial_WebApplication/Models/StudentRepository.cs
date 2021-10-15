using System.Collections.Generic;
using System.Linq;

namespace MVC_Core_WebApplication.Models
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _Students_List;
        public StudentRepository()
        {
            _Students_List = new List<Student>()
            { new Student() { Id = 1},
              new Student() { Id = 2},
              new Student() { Id = 3}
            };
        }

        public Student GetStudent(int Id)
        {
            return _Students_List.FirstOrDefault(e => e.Id == Id);
        }

    }
}
