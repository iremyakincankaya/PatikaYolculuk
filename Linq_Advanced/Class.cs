﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Advanced
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Grade
    {
        public int StudentId { get; set; }
        public string Course { get; set; }
        public int Score { get; set; }
    }

}
