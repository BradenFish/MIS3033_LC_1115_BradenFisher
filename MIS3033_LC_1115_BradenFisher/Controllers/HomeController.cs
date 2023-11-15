using a;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MIS3033_LC_1115_BradenFisher.Data;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace MIS3033_LC_1115_BradenFisher.Controllers
{
    public class HomeController : Controller
    {

        StuDB db = new StuDB();
        public JsonResult DG()
        {
            //var r = db.Enrollments;
            //var r = db.Enrollments.Include(x => x.Student).Include(x => x.Course);
            //var r = db.Enrollments.Select((Enrollment a) => new {G = a.Grade, LG = a.LetterGrade});
            //var r = db.Enrollments.Select((Enrollment a) => new { G = a.Grade, LG = a.LetterGrade }).Where(a => a.LG == 'A').Where(a => a.G > 95);
            //var r = db.Enrollments.Select((Enrollment a) => new { G = a.Grade, LG = a.LetterGrade }).Where(a => a.LG == 'A' && a.G > 95);
            //var r = db.Enrollments.OrderByDescending(x => x.Grade);
            //var r = db.Enrollments.Max(x => x.Grade);// you will get double value
            //var r = db.Enrollments.ToList().MaxBy(x => x.Grade);
            var r = db.Enrollments.GroupBy(x => x.LetterGrade)
            .Select(x => new {LG = x.Key,N = x.Count(),Average = x.Average(a => a.Grade), }).OrderBy(x => x.LG);
            return Json(r);
        }
        public JsonResult GetStudents()
        {
            return Json(db.Students);
        }
        public JsonResult GetCourses() 
        {
            return Json(db.Courses);
        }
        public JsonResult GetEnrollments()
        {
            return Json(db.Enrollments);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
