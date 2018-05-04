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
                search = search.Where(p => p.Name == name);
            }
            if (price > 0.0m) {
                search = search.Where(p => p.Price == price);
            }
            if (!String.IsNullOrEmpty(cat)) {
                search = search.Where(p => p.Category.Name == cat);
            }
            return search.ToList();
        }
    }
}
