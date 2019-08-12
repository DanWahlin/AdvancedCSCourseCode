using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Chapter8.Formatters
{
    class SoapFormatterDemo
    {
        static void Main(string[] args)
        {
            string path = "../../Formatters/Customer.soap";
            Customer cust = new Customer();
            cust.FirstName = "John";
            cust.LastName = "Doe";
            //SoapFormatter doesn't support generics!
            //List<string> numbers = new List<string>();
            //numbers.Add("123-123-1234");
            //numbers.Add("321-654-5876");
            //cust.PhoneNumbers = numbers;

            Console.WriteLine("Serializing Customer object!");

            SoapFormatter sf = new SoapFormatter();
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            sf.Serialize(fs, cust);
            fs.Close();

            Console.WriteLine("Customer object serialized!");
            Console.WriteLine("Customer being deserialized");

            FileStream fs2 = new FileStream(path,FileMode.Open);
            Customer custFromFile = (Customer)sf.Deserialize(fs2);
            Console.WriteLine("Customer name: " + cust.FirstName + " " + cust.LastName);
            fs2.Close();
            Console.Read();
        }
    }
}
