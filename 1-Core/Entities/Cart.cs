﻿using Microsoft.VisualBasic;
using System;

namespace SoupLocal._1_Core.Entities
{
    public class Cart
    {
        public int IdCart { get; set; }
        public int UserId { get; set; }
        public int[] CourseId { get; set; }
        public DateFormat Schedule { get; set; }
    }
}
