using Business_Objects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVCPractice.Controllers
{
    public class CourseController : Controller
    {
        BAL.BAL bal = new BAL.BAL();
        public IActionResult Index()
        {
            var list = bal.GetAllCourses();
            if (list.Count == 0)
            {
                ViewBag.Msg = "There is no record";
                return View();
            }

            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            bal.AddCourses(course);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var course = bal.GetRecordById(id);
            return View(course);
        }
        [HttpPost]
        public IActionResult Delete(Course course,int id)
        {
            if(course != null)
            {
                View(course);
                bal.DeleteCourse(id);
            }
           

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var course = bal.GetRecordById(id);
            return View(course);
        }
        [HttpPost]
        public IActionResult Edit(Course course, int id)
        {
            if (course != null)
            {
                View(course);
                bal.EditCourse(course,id);
            }


            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var course = bal.GetRecordById(id);
            return View(course);

        }

    }
}
