using System;
using System.Collections.Generic;
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
        public ActionResult Register(Register register)
        {

            db.SaveChanges();
            return Redirect("/Product/Register");
        }
    }
}