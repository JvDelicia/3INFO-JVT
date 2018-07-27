using RenatinhaPlace.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace {
    public class ClientDAO {
        private EntitiesContext context;

        public ClientDAO() { context = new EntitiesContext(); }

        public void Add(Client client) {
            context.Clients.Add(client);
            context.SaveChanges();
        }
       /* public Client FindId(int id) {
            return context.Clients.FirstOrDefault(u => u.PeopleId == id);
        }/*/
        public void Remove(Client client) {
            context.Clients.Remove(client);
            context.SaveChanges();
        }
        public void Update() {
            context.SaveChanges();
        }

        public  IList<Client> List()
        {
            var busca = from p in context.Clients select p;            
            return busca.ToList();
            
        }
    }
}
