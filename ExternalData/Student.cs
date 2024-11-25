﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalData
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Major at their university
        public string Major { get; set; }

        public Student(int id, string firstName, string lastName, string major)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Major = major;
        }
    }
}
