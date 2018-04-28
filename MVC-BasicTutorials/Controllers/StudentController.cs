using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_BasicTutorials.Models;

namespace MVC_BasicTutorials.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentList = new List<Student>
            {
                new Student() { StudentId = 1, StudentName = "Younus", Age = 26},
                new Student() { StudentId = 2, StudentName = "Balaji", Age = 27 },
                new Student() { StudentId = 3, StudentName = "Niyaz", Age = 19}
            };

            //return "This is Index action method of StudentController";
            return View(studentList);
        }
    }
}