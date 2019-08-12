using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;


namespace DataDemos.DataAdapter_DataSet {
	public class DataSetDemo {

		public static void Main() {
            string str1 = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
			string str2 = "SELECT * FROM Customers WHERE CustomerID LIKE \'A%\'";
			string str3 = "SELECT * FROM Orders WHERE CustomerID LIKE \'A%\'";
			SqlConnection sqlConnection = new SqlConnection(str1);
			SqlCommand sqlCommand1 = new SqlCommand(str2, sqlConnection);
			SqlCommand sqlCommand2 = new SqlCommand(str3, sqlConnection);
			SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			DataSet dataSet = new DataSet();
			sqlDataAdapter1.Fill(dataSet, "Customers");
			sqlDataAdapter2.Fill(dataSet, "Orders");

			DataColumn dataColumn2 = dataSet.Tables["Customers"].Columns["CustomerID"];
			DataColumn dataColumn1 = dataSet.Tables["Orders"].Columns["CustomerID"];
			DataRelation dataRelation = new DataRelation("CustOrders", dataColumn2, dataColumn1);
			dataSet.Relations.Add(dataRelation);
			foreach (DataRow row in dataSet.Tables["Customers"].Rows) {
				Console.WriteLine(row["ContactName"].ToString());
				DataRow[] dataRows = row.GetChildRows(dataRelation);
				foreach (DataRow childRow in dataRows) {
					Console.WriteLine(String.Concat("\t", childRow["OrderID"].ToString(), " ", childRow["OrderDate"].ToString()));
				}
			}

			Console.ReadLine();
		}
	}

}

