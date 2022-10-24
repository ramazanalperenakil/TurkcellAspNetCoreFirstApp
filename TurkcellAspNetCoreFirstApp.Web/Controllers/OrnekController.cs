using Microsoft.AspNetCore.Mvc;

namespace TurkcellAspNetCoreFirstApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public class ProductOld
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public IActionResult Index()
        {


            ViewBag.name = "ASP Net Core";
            ViewBag.name = new List<string>() { "Ali", "Hasan", "Mehmet" };
            ViewData["NameList"] = new List<string>() { "Ali", "Hasan", "Mehmet" };
            ViewData["age"] = 22;
            TempData["tasiyici"] = "Taşınıyor";

            ViewBag.Person = (new { Id = 1, Name = "Kalem 1", Age = 100 });
            return View();
        }

        public IActionResult Listeleme()
        {
            var ProductList = new List<ProductOld>()
            {
                new ProductOld() { Id = 1, Name ="Kalem" },
                new ProductOld() { Id = 2, Name ="Defter" },
                new ProductOld() { Id = 3, Name ="Silgi" }
            };

            
            return View(ProductList);
        }


        public IActionResult Index2()
        {
            return RedirectToAction("Index", "Ornek");
            /*return View()*/
             
        }
        public IActionResult Index3()
        {
            return View();
           
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
