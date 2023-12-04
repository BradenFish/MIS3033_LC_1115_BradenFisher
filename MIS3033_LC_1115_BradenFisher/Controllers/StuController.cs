using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MIS3033_LC_1115_BradenFisher.Data;
using System.Globalization;

namespace MIS3033_LC_1115_BradenFisher.Controllers
{
    public class StuController : Controller// Controller name is Stu
    {
        // IActionResult: View, web page
        // JsonResult: web api

        StuDB db = new StuDB();// StuDB, Complex, memberfield

        public JsonResult getlg(string id)
        {
            var r = db.Enrollments.Where(x => x.CourseID == id).
            GroupBy(x => x.LetterGrade).
            Select(x => new {lg = x.Key, n = x.Count()}).
            OrderBy(x => x.lg);
            return Json(r);
        }

        public JsonResult getsc()
        {
            var r = db.Courses.Select(x => new {id = x.Id, text = $"ID:{x.Id}, Name:{x.Name}"});
            return Json(r);
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Course()
        {
            return View();
        }
        
        public IActionResult Enrollment()
        {
            return View();
        }

        [Authorize(Roles = "Teacher")]
        public IActionResult Chart()
        {
            return View();
        }

        public JsonResult GetStus()// function name: GetStus, web api
        {
            var r = db.Students.Select(x => new {Id=x.Id, Name=x.Name, favPlace=x.favPlace, DOB=x.DOB.ToString("MM/dd/yyyy"), lat=x.lat, lon=x.lon  });
            return Json(db.Students);
        }

        [Authorize(Roles ="Student, Teacher")]
        public IActionResult Index()// function, action,
        {
            return View();
        }
    }
}
