using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MyWebProject.Models
{
    public class MyWebContext : DbContext
    {
        public MyWebContext() : base("ConnectionString")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<CnicDetails> CnicDetails { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}