using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebProject.Models
{
    public class CnicDetails
    {
        public int Id { get; set; }
        public int CnicNumber { get; set; }
        public virtual Student Student { get; set; }  // Forigen key
        public int StudentId { get; set; }
    }
}