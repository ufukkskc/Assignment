﻿using System;

namespace EFCodeFirstStudentApp
{
    public class Student
    {
        public int StudentId { get; set; }  // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
