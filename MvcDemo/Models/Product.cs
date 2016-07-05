using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
    }
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}