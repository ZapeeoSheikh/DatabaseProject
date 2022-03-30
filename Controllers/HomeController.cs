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

        [HttpGet]
        public ActionResult Students()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }
        [HttpPost]
        public ActionResult Students(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Redirect("/Home/Students");
        }
        [HttpGet]
        public ActionResult CnicDetails()
        {
            List<CnicDetails> cnicDetails = db.CnicDetails.ToList();
            return View(cnicDetails);
        }
        [HttpPost]
        public ActionResult CnicDetails(CnicDetails cnicDetails)
        {
            db.CnicDetails.Add(cnicDetails);
            db.SaveChanges();
            return Redirect("/Home/CnicDetails");
        }
        [HttpGet]
        public ActionResult Course()
        {
            List<Course> courses = db.Courses.ToList();
            return View(courses);
        }
        [HttpPost]
        public ActionResult Course(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
            return Redirect("/Home/Course");
        }
        [HttpGet]
        public ActionResult Enrollment()
        {
            List<Enrollment> enrollments = db.Enrollments.ToList();
            return View(enrollments);
        }
        [HttpPost]
        public ActionResult Enrollment(Enrollment enrollment)
        {
            db.Enrollments.Add(enrollment);
            db.SaveChanges();
            return Redirect("/Home/Enrollment");
        }

        [HttpGet]
        public ActionResult Gender()
        {
            List<Gender> genders = db.Genders.ToList();
            return View(genders);
        }
        [HttpPost]
        public ActionResult Gender(Gender gender)
        {
            db.Genders.Add(gender);
            db.SaveChanges();
            return Redirect("/Home/Gender");
        }
    }
}