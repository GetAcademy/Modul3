using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLtesteting
{
    class Program
    {
        static void Main()
        {
            string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Minecraft;Integrated Security = True;";
            SqlConnection Connection = new SqlConnection(ConnectionString);

            var result = Connection.Query<Movie>("select title, year from movies");
        }
    }

    class Movie
    {
        public string Title;
        public int Year;
    }
}
