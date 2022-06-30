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
        public ActionResult SView(int Id)
        {
            Student students = db.Students.Where(x => x.Id == Id).FirstOrDefault();
            return View(students);
        }
        public ActionResult SDelete(int Id)
        {
            Student students = db.Students.Where(x => x.Id == Id).FirstOrDefault();
            db.Students.Remove(students);
            db.SaveChanges();
            return Redirect("/Home/Students");
        }
        public ActionResult EView(int Id)
        {
            Enrollment enrollment = db.Enrollments.Where(x => x.Id == Id).FirstOrDefault();
            return View(enrollment);
        }
        public ActionResult EDelete(int Id)
        {
            Enrollment enrollment = db.Enrollments.Where(x => x.Id == Id).FirstOrDefault();
            db.Enrollments.Remove(enrollment);
            db.SaveChanges();
            return Redirect("/Home/Enrollment");
        }
        public ActionResult CView(int Id)
        {
            Course course = db.Courses.Where(x => x.Id == Id).FirstOrDefault();
            return View(course);
        }
        public ActionResult CDelete(int Id)
        {
            Course course = db.Courses.Where(x => x.Id == Id).FirstOrDefault();
            db.Courses.Remove(course);
            db.SaveChanges();
            return Redirect("/Home/Course");
        }
        public ActionResult CDView(int Id)
        {
            CnicDetails cnic = db.CnicDetails.Where(x => x.Id == Id).FirstOrDefault();
            return View(cnic);
        }
        public ActionResult CDDelete(int Id)
        {
            CnicDetails cnic = db.CnicDetails.Where(x => x.Id == Id).FirstOrDefault();
            db.CnicDetails.Remove(cnic);
            db.SaveChanges();
            return Redirect("/Home/Cnicdetails");
        }
        public ActionResult GView(int Id)
        {
            Gender gender = db.Genders.Where(x => x.Id == Id).FirstOrDefault();
            return View(gender);
        }
        public ActionResult GDelete(int Id)
        {
            Gender gender = db.Genders.Where(x => x.Id == Id).FirstOrDefault();
            db.Genders.Remove(gender);
            db.SaveChanges();
            return Redirect("/Home/Gender");
        }
        [HttpGet]
        public ActionResult SEdit(int Id)
        {
            Student student = db.Students.Where(x => x.Id == Id).FirstOrDefault();

            db.SaveChanges();
            return View(student);
        }
        [HttpPost]
        public ActionResult SEdit(Student student)
        {
            Student dbstudent = db.Students.Where(x => x.Id == student.Id).FirstOrDefault();
            dbstudent.Name = student.Name;
            dbstudent.Email = student.Email;
            dbstudent.Phone = student.Phone;
            dbstudent.Password = student.Password;
            db.SaveChanges();
            return Redirect("/Home/Students");
        }
        [HttpGet]
        public ActionResult GEdit(int Id)
        {
            Gender gender = db.Genders.Where(x => x.Id == Id).FirstOrDefault();

            db.SaveChanges();
            return View(gender);
        }
        [HttpPost]
        public ActionResult GEdit(Gender gender)
        {
            Gender dbgender = db.Genders.Where(x => x.Id == gender.Id).FirstOrDefault();
            dbgender.Name = gender.Name;
            dbgender.Genderr = gender.Genderr;

            db.SaveChanges();
            return Redirect("/Home/Gender");
        }
        [HttpGet]
        public ActionResult EEdit(int Id)
        {
            Enrollment enrollment = db.Enrollments.Where(x => x.Id == Id).FirstOrDefault();

            db.SaveChanges();
            return View(enrollment);
        }
        [HttpPost]

        public ActionResult EEdit(Enrollment enrollment)
        {
            Enrollment dbenrollment = db.Enrollments.Where(x => x.Id == enrollment.Id).FirstOrDefault();
            dbenrollment.JoinOndate = enrollment.JoinOndate;
            dbenrollment.CourseId = enrollment.CourseId;
            dbenrollment.StudentId = enrollment.StudentId;
            db.SaveChanges();
            return Redirect("/Home/Enrollment");
        }
        [HttpGet]
        public ActionResult CEdit(int Id)
        {
            Course course = db.Courses.Where(x => x.Id == Id).FirstOrDefault();

            db.SaveChanges();
            return View(course);
        }
        [HttpPost]
        public ActionResult CEdit(Course course)
        {
            Course dbcourse = db.Courses.Where(x => x.Id == course.Id).FirstOrDefault();
            dbcourse.Title = course.Title;
            dbcourse.Cost = course.Cost;
            dbcourse.Description = course.Description;

            db.SaveChanges();
            return Redirect("/Home/Course");
        }
        [HttpGet]
        public ActionResult CEEdit(int Id)
        {
            CnicDetails cnicDetails = db.CnicDetails.Where(x => x.Id == Id).FirstOrDefault();

            db.SaveChanges();
            return View(cnicDetails);
        }
        [HttpPost]
        public ActionResult CEEdit(CnicDetails cnicDetails)
        {
            CnicDetails dbCnicDetails = db.CnicDetails.Where(x => x.Id == cnicDetails.Id).FirstOrDefault();
            dbCnicDetails.StudentId = cnicDetails.StudentId;
            dbCnicDetails.CnicNumber = cnicDetails.CnicNumber;

            db.SaveChanges();
            return Redirect("/Home/CnicDetails");
        }

        [HttpGet]
        public ActionResult Students()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }
        [HttpPost]
        public ActionResult Students(Student student)  // New Student Passed and redirected to the student table page 
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