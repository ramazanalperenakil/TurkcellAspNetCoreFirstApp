using Microsoft.AspNetCore.Mvc;

namespace TurkcellAspNetCoreFirstApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepostory _productRepostory;
        public ProductsController()
        {
            _productRepostory=new ProductRepostory();
            if (!_productRepostory.GetAll().Any())
            {
                _productRepostory.Add(new() { Id = 1, Name = "Kalem", Price = 15, Stock = 150 });
                _productRepostory.Add(new() { Id = 2, Name = "Silgi", Price = 5, Stock = 75 });
                _productRepostory.Add(new() { Id = 3, Name = "Defte", Price = 30, Stock = 35 });
                _productRepostory.Add(new() { Id = 4, Name = "Kitap", Price = 50, Stock = 100 });
            }
          
        }
        public IActionResult Index()
        {
            var products = _productRepostory.GetAll();
            return View(products);
        }

        public IActionResult Remove(int id)
        {
           _productRepostory.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Add( )
        {

            return View();
        }
        public IActionResult Update(int id)
        {

            return View();
        }
    }
}
