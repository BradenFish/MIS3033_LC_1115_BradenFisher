using Microsoft.AspNetCore.Mvc;

namespace MIS3033_LC_1115_BradenFisher.Controllers
{
    public class StuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
