using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Interfaces
{
    class IClonableProgram
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.FirstName = "John";
            emp.Department = "Finance";
            Address addr = new Address();
            addr.City = "Phoenix";
            addr.State = "Arizona";
            addr.Street = "1234 Anywhere St.";
            emp.Address = addr;

            Employee clone = emp.Clone() as Employee;

            Console.WriteLine("Employee first name: " + emp.FirstName);
            Console.WriteLine("Clone first name: " + clone.FirstName);
            Console.WriteLine("Clone street: " + clone.Address.Street);
            Console.WriteLine(clone.ToString());
            Console.Read();
        }
    }
}
