using LojaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO {
    public class UserDAO {

        private EntityContext context;

        public UserDAO() {
            context = new EntityContext();
        }

        public IList<User> UserList() {
            return context.Users.ToList();
        }

        public User FindById(int id) {
            return context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Insert(User user) {
            context.Users.Add(user);
            context.SaveChanges();
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