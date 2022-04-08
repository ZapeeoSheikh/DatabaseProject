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

    }
}