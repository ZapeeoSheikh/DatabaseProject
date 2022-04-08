using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebProject.Models;

namespace MyWebProject.Controllers
{
    public class ProductController : Controller
    {
        MyWebContext db = new MyWebContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            user.RoleId = 2;
            user.AccessToken = DateTime.UtcNow.Ticks.ToString();
            db.Users.Add(user);
            db.SaveChanges();
            return Redirect("/Product/Index");
        }
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {

            return Redirect("/Product/Login");
        }
    }
}