using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
    public class ProductDAO {
        private EntityContext context;

        public ProductDAO() {
            context = new EntityContext();
        }

        public IList<Product> ProductList() {
            return context.Products.ToList();
        }

        public Product FindById(int id) {
            return context.Products.FirstOrDefault(u => u.Id == id);
        }

        public void Insert(Product prod) {
            context.Products.Add(prod);
            context.SaveChanges();
        }

        public void Remove(Product prod) {
            context.Products.Remove(prod);
            context.SaveChanges();
        }

        public void Update() {
            context.SaveChanges();
        }
    }
}