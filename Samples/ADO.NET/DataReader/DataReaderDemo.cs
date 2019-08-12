using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataDemos.DataReader {
	public class DataReaderDemo {
		public static void Main() {
            string connString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
			string sql = "SELECT * FROM Products;SELECT * FROM Orders WHERE OrderID < 10500";
			SqlConnection conn = new SqlConnection(connString);
			SqlCommand cmd = new SqlCommand(sql, conn);
			cmd.CommandType = CommandType.Text;  //Default
			conn.Open();

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read()) {  //Read through first results in batch
				Console.WriteLine(reader.GetInt32(0) + ", " +
					reader.GetString(1));
			}
			Console.WriteLine("");
			if (reader.NextResult()) { //Move to next result set
				while (reader.Read()) {
					Console.WriteLine(reader.GetInt32(0) + ", " +
						reader.GetString(1));
				}
			}
			reader.Close();
			conn.Close();

			Console.ReadLine();
		}

	}
}