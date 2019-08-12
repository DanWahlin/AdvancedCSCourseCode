using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Chapter8.IXmlSerializableDemo
{
    class SerializeCar
    {
        static void Main()
        {
            string path = "../../IXmlSerializableDemo/Car.xml";
            Car c = new Car();
            c.Make = "Chevy";
            c.Model = "Tahoe";
            c.Year = 2007;

            Console.WriteLine("Serializing Car to XML using IXmlSerializable interface members");
            XmlSerializer s = new XmlSerializer(typeof(Car));
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            s.Serialize(fs, c);
            fs.Close();
            Console.WriteLine("Car serialized!");

            Console.WriteLine("Deserializing Car using IXmlSerializable interface memebers");
            FileStream fs2 = new FileStream(path, FileMode.Open);
            Car c2 = (Car)s.Deserialize(fs2);
            fs2.Close();
            Console.WriteLine("Car deserialized: " + c.Make + " " + c.Model);
            Console.Read();
        }
    }
}
