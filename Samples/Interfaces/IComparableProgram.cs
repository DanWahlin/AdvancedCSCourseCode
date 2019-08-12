using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Interfaces
{

    class IComparableProgram
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            emp1.FirstName = "John";
            Employee emp2 = new Employee();
            emp2.FirstName = "Adam";

            Employee[] emps = { emp1, emp2 };
            Array.Sort(emps);

            Console.WriteLine("Non-generic sorted list:");
            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp.FirstName);
            }

            Console.WriteLine();

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Sort();

            Console.WriteLine("Generic sorted list:");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp.FirstName);
            }

            Console.Read();
        }
    }
}
