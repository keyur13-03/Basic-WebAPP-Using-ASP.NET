using BasicWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace BasicWebApp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext db;
        public ProductRepository(DataContext db)
        {
            this.db = db;
        }
        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges();
        }

        public int DeleteProduct(int id)
        {
            var prd = db.Products.Where(p => p.ProductId== id).FirstOrDefault();
            db.Products.Remove(prd);
            return db.SaveChanges();
        }


        public Product GetProduct(int id)
        {
            return db.Products.Where(p => p.ProductId== id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public int UpdateProduct(int id, Product product)
        {
            var p = db.Products.Where(p => p.ProductId == id).FirstOrDefault();
            p.ProductId = product.ProductId;
            p.Name = product.Name; ;
            p.Brand = product.Brand;
            p.Quantity = product.Quantity;
            p.Price = product.Price;
            db.Entry(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
