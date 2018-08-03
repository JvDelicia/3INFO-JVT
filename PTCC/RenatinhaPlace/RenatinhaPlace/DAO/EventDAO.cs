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

        public Event FindId(int id) {
             return context.Events.FirstOrDefault(u => u.Id == id);
         }



        public void Remove(Event even)
        {
            context.Events.Remove(even);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Event> List()
        {
            var busca = from p in context.Events select p;
            return busca.ToList();

        }

        public IList<Event> Filter(int idevent, string nameevent)
        {
            var busca = from c in context.Events select c;
            if (idevent > 0.0m)
            {
                busca = from c in context.Events
                        where c.Id == idevent
                        orderby c.Id
                        select c;
            }
            if (!String.IsNullOrEmpty(nameevent))
            {
                busca = from c in context.Events
                        where c.Name == nameevent
                        orderby c.Name
                        select c;
            }
            return busca.ToList();
        }
    }
}
