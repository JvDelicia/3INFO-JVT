using LojaVirtual.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual {
    public class UserDAO {

        private EntitiesContext context;

        public UserDAO() { context = new EntitiesContext(); }

        public void Add(User user) {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public User FindId(int id) {
            return context.Users.FirstOrDefault( u => u.Id == id);
        }
        public void Remove(User user) {
            context.Users.Remove(user);
            context.SaveChanges();
        }
        public void Update() {
            context.SaveChanges();
        }
    }
}