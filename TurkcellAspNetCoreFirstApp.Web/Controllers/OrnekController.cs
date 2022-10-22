using Microsoft.AspNetCore.Mvc;

namespace TurkcellAspNetCoreFirstApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "ASP Net Core";
            ViewBag.name = new List<string>() {"Ali","Hasan","Mehmet" };
            ViewData["NameList"] = new List<string>() {"Ali","Hasan","Mehmet" };
            ViewData["age"] = 22;


            ViewBag.Person = (new { Id = 1, Name = "Kalem 1", Age = 100 });
            return View();
        }
        public IActionResult Index2()
        {
            return RedirectToAction("Index", "Ornek");
            /*return View()*/;
        }
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("jsonResultParametre", "Ornek" ,new { id = id });
            /*return View()*/
            ;
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult jsonResult()
        {
            return Json(new {Id=1, name="Kalem 1", price = 100});
        }

        public IActionResult jsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }

        public IActionResult Empty()
        {
            return Empty();
        }
    }
}
