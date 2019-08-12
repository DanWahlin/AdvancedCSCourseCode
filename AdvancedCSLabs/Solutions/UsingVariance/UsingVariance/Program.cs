using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingVariance
{
    class Program
    {
        public static void ProcessEmployee(IEnumerable<Employee> emps)
        {
            foreach (var emp in emps)
            {
                Console.WriteLine("Employee: {0} {1}",
                    emp.FirstName, emp.LastName);
            }
        }

        public static void Main()
        {
            var mgrs = new List<Manager>
            {
                new Manager { FirstName = "John", LastName = "Doe"},
                new Manager { FirstName = "Jane", LastName = "Doe"},
            };
            ProcessEmployee(mgrs);

            IEnumerable<Manager> distinctEmps =
                mgrs.Distinct<Manager>(new EmployeeComparer());

            foreach (var employee in distinctEmps)
                Console.WriteLine(employee.FirstName + " " + employee.LastName);

            Console.Read();
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Manager : Employee { }

    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if (Object.ReferenceEquals(x, y)) return true;
            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode(Employee emp)
        {
            int hashFirstName = emp.FirstName.GetHashCode();
            int hashLastName = emp.LastName.GetHashCode();
            return hashFirstName ^ hashLastName;
        }
    }

}
