using Microsoft.AspNetCore.Mvc;

namespace LMS.web.Areas.Demos.Controllers
{
    [Area("Demos")]
    public class MyDemoController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello world");
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}
