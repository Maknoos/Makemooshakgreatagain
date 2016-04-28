﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class School
    {
        public int id { get; set; }
        public string name { get; set; }
        public string headmasterName { get; set; }
        public List<Teacher> teachers;
        public List<Student> students;
        public List<Admin> admins;

    }
}
