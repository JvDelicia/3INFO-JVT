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

            UserDAO dao = new UserDAO();

            //ADD
            //User Client = new User() { Name = "Malu", Pass = "123" };
            //dao.Add(Client);
            //Console.WriteLine( Properties.Resources.Saved );

            //FIND
            //User Client = dao.FindId(5);
            //Console.WriteLine( Client.Name );

            //REMOVE
            //User Client = dao.FindId(2);
            //dao.Remove(Client);
            //Console.WriteLine( Properties.Resources.Removed );

            //UPDATE
            //User Client = dao.FindId(4);
            //Client.Pass = "noob";
            //dao.Update();
            //Console.WriteLine(Properties.Resources.Updated);

            //NEW CONTEXTS - Category and Product
            EntitiesContext context = new EntitiesContext();
            Category cat = new Category() { Name = "Informática" };
            context.Categories.Add(cat);
            context.SaveChanges();

            Product prod = new Product() { Name = "Notebook Tijolo", Price = 20, Category = cat };
            context.Products.Add(prod);
            context.SaveChanges();
            Console.WriteLine( Properties.Resources.Register );

            Console.ReadLine();
        }
    }
}
