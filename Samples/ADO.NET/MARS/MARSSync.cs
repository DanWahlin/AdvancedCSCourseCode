using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace DataDemos.MARS
{
    class MARSSync
    {
        public void GetData()
        {
            string sqlCusts = "SELECT TOP 10 * FROM Customers";
            string sqlEmps = "SELECT * FROM Orders WHERE CustomerID = @CustomerID";
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["Northwind"];
            SqlConnection conn = new SqlConnection(cs.ConnectionString);
            SqlCommand cmdCustomers = new SqlCommand(sqlCusts, conn);
            conn.Open();
            SqlDataReader reader = cmdCustomers.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["ContactName"].ToString());
                SqlCommand cmdOrders = new SqlCommand(sqlEmps, conn);
                cmdOrders.Parameters.AddWithValue("@CustomerID",reader["CustomerID"].ToString());
                SqlDataReader readerOrders = cmdOrders.ExecuteReader();
                while (readerOrders.Read())
                {
                    Console.WriteLine(readerOrders["OrderID"].ToString());
                }
                readerOrders.Close();
            }
            reader.Close();
            conn.Close();

        }
    }
}
