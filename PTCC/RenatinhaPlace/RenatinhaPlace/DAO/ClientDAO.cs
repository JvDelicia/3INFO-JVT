using RenatinhaPlace.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

       public Client FindId(int id) {
            return context.Clients.FirstOrDefault(u => u.Id == id);
        }

        public IList<Client> FindCpf(string cpf)
        {
            var busca = from c in context.Clients
                        where c.Cpf == cpf
                        select c;
            return busca.ToList();
        }

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

        public IList<Client> Filter(int idcli, string namecli)
        {
            var busca = from c in context.Clients select c;
            if (idcli > 0.0m)
            {
               busca = from c in context.Clients
                            where c.Id == idcli
                            orderby c.Id
                            select c;               
            }
            if (!String.IsNullOrEmpty(namecli))
            {
                busca = from c in context.Clients
                        where c.Name == namecli
                        orderby c.Name
                        select c;
            }
            return busca.ToList();
        }
    }
}
