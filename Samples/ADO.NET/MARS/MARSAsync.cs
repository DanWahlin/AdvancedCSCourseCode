using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading;

namespace DataDemos.MARS
{
    // To emulate a long-running query, wait for 
    // a few seconds before retrieving the real data.
    //"WAITFOR DELAY '0:0:5';SELECT * FROM Customers"

    class MARSAsync
    {
        SqlConnection conn = null;
        public void GetDataAsync()
        {
            string sqlCusts = "SELECT TOP 10 * FROM Customers";
            string sqlEmps = "SELECT TOP 10 * FROM Employees";
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["Northwind"];
            conn = new SqlConnection(cs.ConnectionString);
            conn.Open();
            //Execute first command asynchronously
            SqlCommand cmdCustomers = new SqlCommand(sqlCusts, conn);
            IAsyncResult ar1 = cmdCustomers.BeginExecuteReader();

            //Execute second command asynchronously
            SqlCommand cmdEmployees = new SqlCommand(sqlEmps, conn);
            IAsyncResult ar2 = cmdEmployees.BeginExecuteReader();

            //Wait for both asynchronous calls to complete
            WaitHandle[] wh = new WaitHandle[] {ar1.AsyncWaitHandle, ar2.AsyncWaitHandle };
            WaitHandle.WaitAll(wh);

            //Process results
            SqlDataReader reader1 = cmdCustomers.EndExecuteReader(ar1);
            Console.WriteLine("Customer Data");
            while (reader1.Read())
            {
                Console.WriteLine(reader1["ContactName"].ToString());
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Employee Data");
            SqlDataReader reader2 = cmdEmployees.EndExecuteReader(ar2);
            while (reader2.Read())
            {
                Console.WriteLine(reader2["FirstName"].ToString() + " " + reader2["LastName"].ToString());
            }
            reader1.Close();
            reader2.Close();
            conn.Close();
        }
        
    }
}
