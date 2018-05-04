using ExeAvaliacao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeAvaliacao {
    class Program {
        static void Main(string[] args) {
            EntitiesContext context = new EntitiesContext();
            StudDAO dao = new StudDAO();
            Stud sdao = new Stud();

            ////Add Students
            //sdao = new Stud() { Name = "Bob",  Tel = "912345678", Class = "Informática" };
            //dao.Add(sdao);
            //sdao = new Stud() { Name = "Ale", Tel = "912345679", Class = "Informática" };
            //dao.Add(sdao);
            //sdao = new Stud() { Name = "Lui", Tel = "912345670",  Class = "Informática" };
            //dao.Add(sdao);
            //sdao = new Stud() { Name = "Jot", Tel = "912345671",  Class = "Segurança" };
            //dao.Add(sdao);
            //Console.WriteLine(Properties.Resources.Add + "\n\n");
            //Console.ReadKey();


            //Mostrar todos
            Console.WriteLine("> Mostrar todos <");
            var search = from p in context.Studs select p;
            foreach (var stud in search) {
                Console.WriteLine(stud.Name);
            }
            Console.WriteLine(Properties.Resources.Cons + "\n\n");
            Console.ReadKey();

            //Mostrar todos + Curso
            Console.WriteLine("> Mostrar todos + Curso <");
            search = from p in context.Studs select p;
            foreach (var stud in search) {
                Console.WriteLine(stud.Name + " from " + stud.Class);
            }
            Console.WriteLine(Properties.Resources.Cons + "\n\n");
            Console.ReadKey();

            //Mostrar only Informática
            Console.WriteLine("> Mostrar todos de Informática <");
            search = from p in context.Studs where (p.Class == "Informática")select p;
            IList<Stud> res = search.ToList();
            foreach (var stud in res) {
                Console.WriteLine(stud.Name);
            }
            Console.WriteLine(Properties.Resources.Cons + "\n\n");
            Console.ReadKey();

            //Order by Tel
            Console.WriteLine("> Ordernar por Telefone <");
            search = from p in context.Studs orderby p.Tel select p;
            res = search.ToList();
            foreach (var stud in res) {
                Console.WriteLine(stud.Name + "\tTel: " + stud.Tel);
            }
            Console.WriteLine(Properties.Resources.Cons + "\n\n");
            Console.ReadKey();

            //Decrease name order by
            Console.WriteLine("> Ordenar, decrescentemente, pelo nome <");
            search = from p in context.Studs orderby p.Name descending select p;
            res = search.ToList();
            foreach (var stud in res) {
                Console.WriteLine(stud.Name + "\tTel: " + stud.Tel);
            }
            Console.WriteLine(Properties.Resources.Cons + "\n\n");
            Console.ReadKey();

            //Finaliza
            Console.WriteLine(Properties.Resources.Fim);
            Console.ReadKey();
        }
    }
}
