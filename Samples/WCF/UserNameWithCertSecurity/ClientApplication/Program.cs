using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientApplication.ProxyReference;

namespace ClientApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalcClient proxy = new CalcClient();
            proxy.ClientCredentials.UserName.UserName = "dan";
            proxy.ClientCredentials.UserName.Password = "password";
            int result = proxy.Add(2, 2);
            Console.WriteLine("Result = " + result.ToString());
            Console.ReadLine();
        }
    }
}
