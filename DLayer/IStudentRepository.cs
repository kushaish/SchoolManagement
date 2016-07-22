using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DLayer
{
    /// <summary>
    /// My Repo Interface more changes
    /// More changes
    /// </summary>
    interface IStudentRepository
    {
        List<Student> GetAllStudent();
        Student GetStudentByID(int Id);
    }
}
