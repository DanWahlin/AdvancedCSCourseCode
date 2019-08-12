using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using XmlForAsp.Configuration;

namespace ServerConfig.Data {
	/// <summary>
	/// Summary description for Northwind.
	/// </summary>
	public class Northwind {

		static string _Database = "Northwind"; 
		static string _PrimaryConnStr = ServerConfigManager.GetConnectionString(_Database).Primary;
		static string _SecondaryConnStr = ServerConfigManager.GetConnectionString(_Database).Secondary;

		public static SqlDataReader GetCustomers() {
			//Bind data to database
			SqlConnection conn = null;
			SqlConnection conn2 = null;
			string sql = "SELECT * FROM Customers";
			try {  //Hit primary database
				conn = new SqlConnection(_PrimaryConnStr);
				SqlCommand cmd = new SqlCommand(sql,conn);
				conn.Open();
				return cmd.ExecuteReader(CommandBehavior.CloseConnection);
			}
			catch (Exception exp) {
				HttpContext.Current.Trace.Write(exp.Message);
				//Log error if desired
				try {	//Hit secondary database if needed
					conn2 = new SqlConnection(_SecondaryConnStr);
					SqlCommand cmd = new SqlCommand(sql,conn2);
					conn2.Open();
					return cmd.ExecuteReader(CommandBehavior.CloseConnection);
				}
				catch {
					HttpContext.Current.Trace.Write(exp.Message);
					//Log error if desired
				}
			}
			return null;
		}
	}
}
