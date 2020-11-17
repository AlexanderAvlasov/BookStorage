using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;

namespace DataAccesLier
{
    public class ProjectDb
    {
        public ProjectDb()
        {
            
        }

        public static SQLiteConnection CreateConnaction() {
            //var ds = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alexander\source\repos\BookStorage\DataAccesLier\DB\BookStore.mdf;Integrated Security=True";
            var con = new SQLiteConnection(@"data source=Resources/DB/BookStore.db");
            con.Open();
            return con;
            //var cmd = new SQLiteCommand("SELECT * FROM books");
            //cmd.Connection = con;
            //var sQLiteDataReader = cmd.ExecuteReader();
            //Console.WriteLine($"has rows? {sQLiteDataReader.HasRows}");
            //while (sQLiteDataReader.Read() && sQLiteDataReader.HasRows)
            //{
            //    Console.WriteLine($"Name :{sQLiteDataReader.GetString(1)} \nAuthor {sQLiteDataReader.GetString(2)} \nPages={sQLiteDataReader.GetDecimal(3)} "); ; ;
            //}
        }
    }
}
