using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace SerializingData
{
    class XmlSerializerDemo
    {
        static void Main()
        {
            string path = "../../Customer.xml";
            Customer cust = new Customer();
            cust.FirstName = "John";
            cust.LastName = "Doe";
            List<string> numbers = new List<string>();
            numbers.Add("123-123-1234");
            numbers.Add("321-654-5876");
            cust.PhoneNumbers = numbers;

            Console.WriteLine("Serializing Customer object to XML!");


            XmlSerializer s = new XmlSerializer(typeof(Customer));
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            s.Serialize(fs, cust);
            fs.Close();

            Console.WriteLine("Customer object serialized to XML!");
            Console.WriteLine("Customer being deserialized");

            XmlReader reader = XmlReader.Create(path);
            if (s.CanDeserialize(reader))
            {
                Customer custFromFile = (Customer)s.Deserialize(reader);
                Console.WriteLine("Customer name: " + cust.FirstName + " " + cust.LastName);
                reader.Close();
            }
            Console.Read();
        }
    }
}
