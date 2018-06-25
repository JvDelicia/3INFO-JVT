using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
    public class CatProdDAO {
        private EntityContext context;

        public CatProdDAO() {
            context = new EntityContext();
        }

        public IList<ProdCategory> CategoryList() {
            return context.Categories.ToList();
        }

        public ProdCategory FindById(int id) {
            return context.Categories.FirstOrDefault(u => u.Id == id);
        }

        public void Insert(ProdCategory cat) {
            context.Categories.Add(cat);
            context.SaveChanges();
        }

        public void Remove(ProdCategory cat) {
            context.Categories.Remove(cat);
            context.SaveChanges();
        }

        public void Update() {
            context.SaveChanges();
        }
    }
}