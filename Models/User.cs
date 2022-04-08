using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }

    }
}