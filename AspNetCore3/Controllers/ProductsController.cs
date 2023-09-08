using AspNetCore3.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore3.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            
            List<Model1> products = new List<Model1>();
            products.Add(new Model1() { Id = 1, Name = "Vlad", Price = 100000 });
            products.Add(new Model1() { Id = 2, Name = "Sergiy", Price = 5000 });
            products.Add(new Model1() { Id = 3, Name = "Andriy", Price = 200000 });
            ViewBag.Products = products;
            return View(products);
        }
    }
}
