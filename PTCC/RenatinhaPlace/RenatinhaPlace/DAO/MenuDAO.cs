using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.DAO
{
    public class MenuDAO
    {
        private EntitiesContext context;

        public MenuDAO() { context = new EntitiesContext(); }

        public void Add(Menu menu)
        {
            context.Menus.Add(menu);
            context.SaveChanges();
        }
        public Menu FindId(int id) {
             return context.Menus.FirstOrDefault(u => u.Id == id);
         }
        public void Remove(Menu menu)
        {
            context.Menus.Remove(menu);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Menu> List()
        {
            var busca = from p in context.Menus select p;
            return busca.ToList();

        }

        public int FindIdByCb(string menucb)
        {
            int posicao = menucb.IndexOf('-');
            menucb = menucb.Substring(0, posicao);
            return int.Parse(menucb);
        }
    }
}
