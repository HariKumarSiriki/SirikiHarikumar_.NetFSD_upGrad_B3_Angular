using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
  
      static  List<Product> products = new List<Product>()
        {
             new Product { Id = 1, Name = "Laptop", Price = 50000, Category = "Electronics" },
             new Product { Id = 2, Name = "Mobile", Price = 20000, Category = "Electronics" },
             new Product { Id = 3, Name = "Shoes", Price = 3000, Category = "Fashion" }
       };

      
        public IActionResult Index()
        {
            return View(products);
        }
        public IActionResult Details(int id)
        {
            Product prodObj = products.FirstOrDefault(item => item.Id == id);
            return View(prodObj);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                products.Add(p);
                return RedirectToAction("Index");
            }

            return View(p);
        }





        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
            var product = products.FirstOrDefault(x => x.Id == p.Id);

            if (product != null)
            {
                product.Name = p.Name;
                product.Price = p.Price;
                product.Category = p.Category;
            }

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                products.Remove(product);
            }

            return RedirectToAction("Index");
        }
    }
}
