using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ThirdProjects.Models;

namespace ThirdProjects.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id= 1, Name = "Product #1", Price = 2000, CreateTime= new DateTime(2020,11,06)},
                new Product(){Id= 2, Name = "Product #2", Price = 2100, CreateTime= new DateTime(2020,10,05)},
                new Product(){Id= 3, Name = "Product #3", Price = 2200, CreateTime= new DateTime(2020,05,24)},
                new Product(){Id= 4, Name = "Product #4", Price = 2300, CreateTime= new DateTime(2020,08,15)},
                new Product(){Id= 5, Name = "Product #5", Price = 2400, CreateTime= new DateTime(2020,01,19)}
            };
            return View(products);
        }
    }
}