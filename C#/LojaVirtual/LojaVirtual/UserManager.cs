using LojaVirtual.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual {
    public class UserManager {

        private EntitiesContext context;

        public UserManager() { context = new EntitiesContext(); }

        public void Save(User user) {
            context.users.Add(user);
            context.SaveChanges();
        }
        public User FindId(int id) {
            return context.users.FirstOrDefault( u => u.id == id);
        }
        public void Remove(User user) {
            context.users.Remove(user);
            context.SaveChanges();
        }
    }
}