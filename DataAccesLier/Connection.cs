using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;

namespace DataAccesLier
{
    public class Connection
    {
        public Connection()
        {
            //var ds = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexander\source\repos\BookStorage\DataAccesLier\DB\BookStore.mdf;Integrated Security=True";
            var con = new SQLiteConnection(@"data source=DB/BookStore.db");
            con.Open();
            var cmd = new SQLiteCommand("SELECT * FROM books");
            cmd.Connection = con;
            var sQLiteDataReader = cmd.ExecuteReader();
            Console.WriteLine($"has rows? {sQLiteDataReader.HasRows}");
            while (sQLiteDataReader.Read()&& sQLiteDataReader.HasRows)
            {
                Console.WriteLine($"Name :{sQLiteDataReader.GetString(1)} \nAuthor {sQLiteDataReader.GetString(2)} \nPages={sQLiteDataReader.GetDecimal(3)} "); ; ;
            }
            Console.WriteLine("Book store");

            //using (SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ALEXANDER\\SOURCE\\REPOS\\BOOKSTORAGE\\CONSOLEAPP1\\BIN\\DEBUG\\NETCOREAPP3.1\\BOOKSTORE.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) {
            //    con.Open();
            //    SqlCommand com = new SqlCommand("select * from books", con);
            //    SqlDataReader reader = com.ExecuteReader();
            //    while (reader.Read()) {
            //        Console.WriteLine($"Name :{reader.GetString(0)} \nAuthor {reader.GetString(1)} \nPages={reader.GetString(2)} ");; ;
            //    }

            //}
        }
    }
}
