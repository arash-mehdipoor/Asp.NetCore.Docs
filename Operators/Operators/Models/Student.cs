﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Student : Person
    {
        public string StudentName { get; set; } 
    }
}
