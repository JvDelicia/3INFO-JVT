using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
           Usuario Astrogildo = new Usuario()
           {
               nome = "Astrogildo",
               senha = "123"
           };

            Console.WriteLine("Usuário salvo");
            Console.ReadLine();
        }
    }
}
