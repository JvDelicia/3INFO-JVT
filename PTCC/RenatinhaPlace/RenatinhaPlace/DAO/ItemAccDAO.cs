using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.DAO
{
    public class ItemAccDAO
    {
        private EntitiesContext context;

        public ItemAccDAO() { context = new EntitiesContext(); }

        public void Add(ItemAcc itemacc)
        {
            context.ItemAccs.Add(itemacc);
            context.SaveChanges();
        }


        public void Remove(ItemAcc itemacc)
        {
            context.ItemAccs.Remove(itemacc);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<ItemAcc> List()
        {
            var busca = from ia in context.ItemAccs select ia;
            return busca.ToList();

        }

        public ItemAcc SearchItemAcc(int idacc, int idprodia)
        {
            return context.ItemAccs.FirstOrDefault(ia => ia.ProductId == idprodia && ia.AccountId == idacc);

        }

    }
}
