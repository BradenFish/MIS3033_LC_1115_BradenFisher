using Microsoft.AspNetCore.Mvc;
using MIS3033_LC_1115_BradenFisher.Data;

namespace MIS3033_LC_1115_BradenFisher.Controllers
{
    public class HomeController : Controller
    {

        StuDB db = new StuDB();
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
