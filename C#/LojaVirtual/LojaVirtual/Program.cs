using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Entities;

namespace LojaVirtual {
    class Program {
        static void Main(string[] args) {
            //string conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbLojaVirtual.mdf;Integrated Security=True;Connect Timeout=30"; //String de conexão
            //IDbConnection con = new SqlConnection(conn);
            //IDbCommand com = con.CreateCommand();
            //com.CommandText = "select * from tbCliente";
            //IDataReader read = com.ExecuteReader();
            //while (read.Read()) {
            //    int Id = Convert.ToInt32(read["Id"]);
            //    string Name = Convert.ToString(read["Name"]);
            //}

            EntitiesContext context = new EntitiesContext();
            User Astrogildo = new User() { name = "Xuxa", pass = "666" };
            context.users.Add(Astrogildo);
            context.SaveChanges();
            context.Dispose(); //Libera do cache

            Console.WriteLine( "Usuário salvo." );
            Console.ReadLine();

        }
    }
}
