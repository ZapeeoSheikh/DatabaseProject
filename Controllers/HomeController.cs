using MyWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        MyWebContext db = new MyWebContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Students()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }
        public ActionResult CnicDetails()
        {
            List<CnicDetails> cnicDetails = db.CnicDetails.ToList();
            return View(cnicDetails);
        }
        public ActionResult Course()
        {
            List<Course> courses = db.Courses.ToList();
            return View(courses);
        }
        public ActionResult Enrollment()
        {
            List<Enrollment> enrollments = db.Enrollments.ToList();
            return View(enrollments);
            return View();
        }
        public ActionResult Gender()
        {
            List<Gender> genders = db.Genders.ToList();
            return View(genders);
        }
    }
}