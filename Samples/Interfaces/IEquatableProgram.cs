using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Interfaces
{
    class IEquatableProgram
    {
        static void Main()
        {
            //IEquatable<T> normally used with numbers or strings
            //Following example shows how it can be used with an Employee class
            //to see if employees are in the same department
            Employee emp1 = new Employee();
            emp1.FirstName = "John";
            emp1.Department = "Finance";

            Employee emp2 = new Employee();
            emp2.FirstName = "Jane";
            emp2.Department = "Finance";

            if (emp1.Equals(emp2))
            {
                Console.WriteLine("Both employees are in the same department.");
            }
            else
            {
                Console.WriteLine("Employees are in different departments.");
            }
            Console.Read();
        }
    }
}
