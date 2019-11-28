using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TietokantaTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify connection options and open an connection
            NpgsqlConnection conn =
                new NpgsqlConnection(
                    "Server=127.0.0.1;User Id=postgres;" +
                    "Password=Grespost99;Database=books;");
            conn.Open();

            // Define a query
            NpgsqlCommand cmd = new NpgsqlCommand("select * from book", conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {
                string id =dr[0].ToString();
                string title = dr[1].ToString();
                Console.WriteLine(id + " " + title);
                // Book b = new Book(int.Parse(dr[0].ToString()), dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
            }
                //Console.Write("{0} {1}\n", dr[0], dr[1]);

            // Close connection
            conn.Close();
        }
    }
}
