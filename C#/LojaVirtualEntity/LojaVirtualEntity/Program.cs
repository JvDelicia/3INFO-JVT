using LojaVirtualEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualEntity {
    class Program {
        static void Main(string[] args) {
            User Client = new User() { name = "Aluno", password = "123" };

            EntitiesContext context = new EntitiesContext();
            context.users.Add(Client);
            context.SaveChanges();
            context.Dispose();

            Console.WriteLine(Strings.First);
            Console.ReadKey();
        }
    }
}
