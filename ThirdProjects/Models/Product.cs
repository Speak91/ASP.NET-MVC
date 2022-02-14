using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThirdProjects.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
    }
}