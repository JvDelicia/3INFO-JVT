using RenatinhaPlace.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace {
    public class ProdDAO {

        private EntitiesContext context;

        public ProdDAO()
        {
            context = new EntitiesContext();
        }

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

        public IList<Product> FindProdsByAccount(int idacc)
        {
            var busca = from p in context.Products
                        join pv in context.ItemMenus on p.Id equals pv.ProductId
                        join m in context.Menus on pv.MenuId equals m.Id
                        join e in context.Events on m.Id equals e.MenuId
                        join t in context.Tickets on e.Id equals t.EventId
                        join a in context.Accounts on t.Id equals a.TicketId
                        select p;

            return busca.ToList();
        }
    }
}
