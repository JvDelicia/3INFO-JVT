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

            UserManager context = new UserManager();

            //User Client = new User() { name = "Malu", pass = "123" };
            //context.Save(Client);
            //Console.WriteLine( Properties.Resources.Saved );

            //User Client = context.FindId(5);
            //Console.WriteLine( Client.name );

            User Client = context.FindId(2);
            context.Remove(Client);
            Console.WriteLine(Properties.Resources.Removed);

            Console.ReadLine();
        }
    }
}
