using RenatinhaPlace.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace {
    class ProdDAO {
        private EntitiesContext context;
        public ProdDAO(EntitiesContext context) { this.context = context; }
        public IList<Product> SearchNPC(string name, decimal price) {
            var search = from p in context.Products select p;
            if (!String.IsNullOrEmpty(name)) {
                search = search.Where(p => p.Name == name);
            }
            if (price > 0.0m) {
                search = search.Where(p => p.PriceUni == price);
            }
            return search.ToList();
        }
    }
}
