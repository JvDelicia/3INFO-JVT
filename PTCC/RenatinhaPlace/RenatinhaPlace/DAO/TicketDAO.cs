using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;
using RenatinhaPlace.DAO;

namespace RenatinhaPlace.DAO
{
    public class TicketDAO
    {
        private EntitiesContext context;

        public TicketDAO() { context = new EntitiesContext(); }

        public void Add(Ticket ticket)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
        }

        public Ticket FindId(int id)
        {
            return context.Tickets.FirstOrDefault(u => u.Id == id);
        }

        public void Remove(Ticket ticket)
        {
            context.Tickets.Remove(ticket);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Ticket> List()
        {
            var busca = from t in context.Tickets select t;
            return busca.ToList();
        }

        public IList<Ticket> FindTicketByEvent(string name)
        {
            var busca = from t in context.Tickets
                        join e in context.Events on t.EventId equals e.Id
                        where e.Name == name
                        select t;
  
            return busca.ToList();
        }

        public int FindIdByCb(string ticketcb)
        {
            int posicao = ticketcb.IndexOf('-');
            ticketcb = ticketcb.Substring(0, posicao);
            return int.Parse(ticketcb);
        }


    }
}
