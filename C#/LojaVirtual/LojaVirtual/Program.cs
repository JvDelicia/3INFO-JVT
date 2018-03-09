using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Entities;

namespace LojaVirtual {
    class Program {
        static void Main(string[] args) {

            User Astrogildo = new User() {
                Name = "Astrogildo",
                Pass = "123"
            };

            Console.WriteLine( "Usuário salvo." );
            Console.ReadLine();

        }
    }
}
