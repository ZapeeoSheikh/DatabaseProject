using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace MyWebProject.Models
{
    public class Login
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
    }
}