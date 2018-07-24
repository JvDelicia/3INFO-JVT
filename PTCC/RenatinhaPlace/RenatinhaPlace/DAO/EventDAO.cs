using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;

namespace RenatinhaPlace.DAO
{
    public class EventDAO
    {
        private EntitiesContext context;

        public EventDAO() { context = new EntitiesContext(); }

        public void Add(Event even)
        {
            context.Events.Add(even);
            context.SaveChanges();
        }

        /* public Event FindId(int id) {
             return context.Events.FirstOrDefault(u => u.EventId == id);
         }/*/

        public void Remove(Event even)
        {
            context.Events.Remove(even);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }
    }
}
