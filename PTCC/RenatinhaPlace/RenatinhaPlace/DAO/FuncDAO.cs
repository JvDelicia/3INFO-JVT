using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.DAO
{
    public class FuncDAO
    {
        private EntitiesContext context;

        public FuncDAO() { context = new EntitiesContext(); }

        public void Add(Func func)
        {
            context.Funcs.Add(func);
            context.SaveChanges();
        }
        /* public Func FindId(int id) {
             return context.Clients.FirstOrDefault(u => u.PeopleId == id);
         }/*/
        public void Remove(Func func)
        {
            context.Funcs.Remove(func);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Func> List()
        {
            var busca = from p in context.Funcs select p;
            return busca.ToList();

        }
    }
}
