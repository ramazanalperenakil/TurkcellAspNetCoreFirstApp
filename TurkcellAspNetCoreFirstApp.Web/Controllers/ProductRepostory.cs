using TurkcellAspNetCoreFirstApp.Web.Models;

namespace TurkcellAspNetCoreFirstApp.Web.Controllers
{
    public class ProductRepostory
    {
        private static List<Product> _Product = new List<Product>();

        public List<Product> GetAll() => _Product;

        public void Add(Product newProduct) => _Product.Add(newProduct);

        public void Remove(int id)
        {
            var hasProduct = _Product.FirstOrDefault(x => x.Id == id);
            if (hasProduct == null)
            {
                throw new Exception("Bu id (" + id + ") ye ait ürün yok");
            }
            _Product.Remove(hasProduct);
        }

        public void Update(Product updateProdact)
        {
            var hasProduct = _Product.FirstOrDefault(x => x.Id == updateProdact.Id);
            if (hasProduct == null)
            {
                throw new Exception("Bu id (" + updateProdact.Id + ") ye ait ürün yok");
            }

            hasProduct.Name=updateProdact.Name; 
            hasProduct.Price=updateProdact.Price;
            hasProduct.Stock=updateProdact.Stock;

            var index = _Product.FindIndex(x => x.Id == updateProdact.Id);
            _Product[index]=hasProduct;
        }

         
    }
}
