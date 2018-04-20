using LojaVirtual.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual {
    public class ProdDAO {
        private EntitiesContext context;
        public ProdDAO(EntitiesContext context) { this.context = context; }
        public IList<Product> SearchNPC(string name, decimal price, string cat) {
            var search = from p in context.Products select p;
            if (!String.IsNullOrEmpty(name)) {
                search = from p in search where p.Name == name select p;
            }
            if (price > 0.0m) {
                search = from p in search where p.Price == price select p;
            }
            if (!String.IsNullOrEmpty(cat)) {
                search = from p in search where p.Category.Name == cat select p;
            }
            return search.ToList();
        }
    }
}
