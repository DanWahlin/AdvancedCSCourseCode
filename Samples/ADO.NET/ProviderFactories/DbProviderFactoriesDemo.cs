using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;

namespace DataDemos.ProviderFactories
{
    class DbProviderFactoriesDemo
    {
        public static void Main()
        {
            DbDataReader reader = GetDataReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["ContactName"].ToString());
            }
            reader.Close();
            Console.ReadLine();
        }

        public static DbDataReader GetDataReader()
        {
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["Northwind"];
            DbProviderFactory f = DbProviderFactories.GetFactory(cs.ProviderName);
            DbConnection conn = f.CreateConnection();
            conn.ConnectionString = cs.ConnectionString;
            DbCommand cmd = f.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Customers";
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
