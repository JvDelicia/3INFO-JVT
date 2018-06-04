using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliaçãoAlunoNota.Entidades;

namespace AvaliaçãoAlunoNota {
    class Program {
        static void Main(string[] args) {
            EntitiesContext context = new EntitiesContext();
            Aluno adao = new Aluno() { Nome = "JV" };
            context.Alunos.Add(adao);
            context.SaveChanges();

            Nota av1 = new Nota() { Nome = "1º nota", Valor = 8, Alunos = adao};
            context.Notas.Add(av1);
            context.SaveChanges();
            Nota av2 = new Nota() { Nome = "2º nota", Valor = 7,  Alunos = adao };
            context.Notas.Add(av2);
            context.SaveChanges();
            Nota av3 = new Nota() { Nome = "3º nota", Valor = 6, Alunos = adao };
            context.Notas.Add(av3);
            context.SaveChanges();

            var search = from p in context.Notas select p;
            var search2 = from w in context.Alunos select w;
            foreach (var n in search) {
                Console.WriteLine(n.Nome + " : " + n.Valor );
            }

            Console.WriteLine("Foi!");
            Console.ReadKey();
        }
    }
}
