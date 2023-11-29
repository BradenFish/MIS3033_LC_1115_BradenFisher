using Microsoft.AspNetCore.Mvc;
using MIS3033_LC_1115_BradenFisher.Data;

namespace MIS3033_LC_1115_BradenFisher.Controllers
{
    public class StuController : Controller// Controller name is Stu
    {
        // IActionResult: View, web page
        // JsonResult: web api

        StuDB db = new StuDB();// StuDB, Complex, memberfield

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

        public IActionResult Chart()
        {
            return View();
        }

        public JsonResult GetStus()// function name: GetStus, web api
        {
            var r = db.Students.Select(x => new {Id=x.Id, Name=x.Name, favPlace=x.favPlace, DOB=x.DOB.ToString("MM/dd/yyyy"), lat=x.lat, lon=x.lon  });
            return Json(db.Students);
        }
        
        public IActionResult Index()// function, action,
        {
            return View();
        }
    }
}
