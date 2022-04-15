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

        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            user.RoleId = 1;
            user.AccessToken = DateTime.UtcNow.Ticks.ToString();
            db.Users.Add(user);
            db.SaveChanges();



            HttpCookie myCookie = new HttpCookie("userCookie");
            myCookie.Value = user.AccessToken;
            myCookie.Expires = DateTime.UtcNow.AddDays(5).AddHours(5);
            Response.Cookies.Remove("userCookie");
            Response.Cookies.Add(myCookie);
            return Redirect("/Product/Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            //goes to =>
            User dbuser = db.Users.Where(m => m.Email == user.Email && m.Password == user.Password).FirstOrDefault();
            if (dbuser == null)
            {
                ViewBag.Error = "Your email or password is incorrect";
                return View();
            }
            HttpCookie mycookie = new HttpCookie("userCookie");
            mycookie.Value = dbuser.AccessToken;
            mycookie.Expires = DateTime.UtcNow.AddDays(5).AddHours(5);
            Response.Cookies.Remove("userCookie");
            Response.Cookies.Add(mycookie);
            return Redirect("/Home/Index");
        }
    }
}