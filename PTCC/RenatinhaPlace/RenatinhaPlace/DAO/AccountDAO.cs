using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.DAO
{
    public class AccountDAO
    {
        private EntitiesContext context;

        public AccountDAO() { context = new EntitiesContext(); }

        public void Add(Account account)
        {
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public Account FindId(int id)
        {
            return context.Accounts.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Account account)
        {
            context.Accounts.Remove(account);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Account> List()
        {
            var busca = from p in context.Accounts select p;
            return busca.ToList();
        }



    }
}
