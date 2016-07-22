using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DLayer
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAllStudent()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { ID = 1, StudentName = "Ashish", Age = 30, TotalCourseEnrolled = 10 });
            studentList.Add(new Student { ID = 2, StudentName = "Shantanu", Age = 31, TotalCourseEnrolled = 5 });
            studentList.Add(new Student { ID = 3, StudentName = "Pankaj", Age = 29, TotalCourseEnrolled = 21 });
            return studentList;
        }

        public Student GetStudentByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
