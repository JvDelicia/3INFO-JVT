using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.DAO
{
    public class ProdDAO
    {
        private EntitiesContext context;

        public ProdDAO() { context = new EntitiesContext(); }

        public void Add(Product prod)
        {
            context.Products.Add(prod);
            context.SaveChanges();
        }
        public Product FindId(int id)
        {
            return context.Products.FirstOrDefault(u => u.Id == id);
        }
        public void Remove(Product prod)
        {
            context.Products.Remove(prod);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Product> FindProdsByAccount(int idacc)
        {
            var busca = from p in context.Products
                        join im in context.ItemMenus on p.Id equals im.ProductId
                        join m in context.Menus on im.MenuId equals m.Id
                        join e in context.Events on m.Id equals e.MenuId
                        join t in context.Tickets on e.Id equals t.EventId
                        join a in context.Accounts on t.Id equals a.TicketId
                        where a.Id == idacc
                        select p;

            return busca.ToList();

        }

        public IList<Product> Filter(int idacc, int idprod, string nameprod)
        {
            var buscafiltro = from p in context.Products
                        join im in context.ItemMenus on p.Id equals im.ProductId
                        join m in context.Menus on im.MenuId equals m.Id
                        join e in context.Events on m.Id equals e.MenuId
                        join t in context.Tickets on e.Id equals t.EventId
                        join a in context.Accounts on t.Id equals a.TicketId
                        where a.Id == idacc
                        select p;

            if (idprod > 0.0m)
            {
                buscafiltro = from p in context.Products
                        join im in context.ItemMenus on p.Id equals im.ProductId
                        join m in context.Menus on im.MenuId equals m.Id
                        join e in context.Events on m.Id equals e.MenuId
                        join t in context.Tickets on e.Id equals t.EventId
                        join a in context.Accounts on t.Id equals a.TicketId
                        where a.Id == idacc && p.Id == idprod
                        select p;
            }
            if (!String.IsNullOrEmpty(nameprod))
            {
                buscafiltro = from p in context.Products
                              join im in context.ItemMenus on p.Id equals im.ProductId
                              join m in context.Menus on im.MenuId equals m.Id
                              join e in context.Events on m.Id equals e.MenuId
                              join t in context.Tickets on e.Id equals t.EventId
                              join a in context.Accounts on t.Id equals a.TicketId
                              where a.Id == idacc && p.Name == nameprod
                              select p;
            }
            return buscafiltro.ToList();
        }

        public IList<Product> ListProdsAcc(int idacc)
        {
            var busca = from p in context.Products
                        join ia in context.ItemAccs on p.Id equals ia.ProductId
                        where ia.AccountId == idacc
                        select p;
            return busca.ToList();

        }
    }
}
