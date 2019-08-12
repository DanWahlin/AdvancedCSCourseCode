using System;
using System.Data.SqlClient;
using ServerConfig.Data;

namespace ServerConfig.Biz {
	/// <summary>
	/// Summary description for Northwind.
	/// </summary>
	public class Northwind {
		public static SqlDataReader GetCustomers() {
			//Perform any business logic if desired here...
			//Call data layer (see Data/Northwind.cs)
			return Data.Northwind.GetCustomers();
		}
	}
}
