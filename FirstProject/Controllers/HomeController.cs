using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Product #1", Price = 100},
                new Product() { Id = 2, Name = "Product #2", Price = 200},
                new Product() { Id = 3, Name = "Product #3", Price = 300},
                new Product() { Id = 4, Name = "Product #4", Price = 400},
                new Product() { Id = 5, Name = "Product #5", Price = 500}

            };
            
            return View(products);

        }
       
    }
}