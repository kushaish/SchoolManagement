﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSampleApplication.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string  StudentName { get; set; }
        public int Age { get; set; }
        public int TotalCourseEnrolled { get; set; }
    }
}