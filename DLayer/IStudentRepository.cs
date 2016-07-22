﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DLayer
{
    /// <summary>
    /// My Repo Interface
    /// </summary>
    interface IStudentRepository
    {
        List<Student> GetAllStudent();
        Student GetStudentByID(int Id);
    }
}
