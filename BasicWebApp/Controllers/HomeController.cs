using BasicWebApp.Models;
using BasicWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository repo;

        public HomeController(IProductRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View(repo.GetProducts());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            repo.AddProduct(product);
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            return View(repo.GetProduct(id));
        }
        [HttpPost]
        public IActionResult Delete(int id, Product product)
        {
            repo.DeleteProduct(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            return View(repo.GetProduct(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            repo.UpdateProduct(id,product);
            return RedirectToAction("Index");
        }






    }
}
