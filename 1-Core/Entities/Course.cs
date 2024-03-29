﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoupLocal._1_Core.Entities
{
    public class Course
    {
        public int IdCourse { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Img { get; set; }
        public string Desc { get; set; }
    }
}
