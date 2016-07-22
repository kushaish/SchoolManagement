using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLayer;
namespace BLayer
{
    public class BusinessLayer
    {
        public List<Student> GetAllStudent()
        {
            StudentRepository rep = new StudentRepository();
            return rep.GetAllStudent();
        }
    }
}
