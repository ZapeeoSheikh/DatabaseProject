using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebProject.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        public virtual Student Student { get; set; }
        public int StudentId { get; set; }


        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        public string JoinOndate { get; set; }
    }
}