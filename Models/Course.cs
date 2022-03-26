using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebProject.Models
{
    public class Course
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
    }
}