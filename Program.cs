using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee("0000", "Marcos", "Barrero", new DateTime(2006, 03, 04), 1301.01f, 30),
                new Employee(),
                new Employee("0001", "Ruben", "Borrego", new DateTime(2006, 07, 02)),
                new Employee("0002", "Gabri", "De Souza", new DateTime(1939, 04, 01), 0.01f, 1),
                new Employee("0003", "Elon", "Musk", DateTime.Now)
            };
            List<SalesEmployee> salesEmployeeList = new List<SalesEmployee>() {
                new SalesEmployee("0010", "Leon", "Kennedy", new DateTime(2006, 03, 04), 10301.01f, 30, 2.0f),
                new SalesEmployee(),
                new SalesEmployee("0011", "Gabro", "Chill", new DateTime(2006, 07, 02), 1000f, 24, 1.0f),
                new SalesEmployee("0012", "Cabri", "De Mostaza", new DateTime(1939, 04, 01), 0.01f, 1, 0.10f),
                new SalesEmployee("0013", "Elun", "Mosk", DateTime.Now, 1000000.00f, 1, 0.01f)
            };
            employeeList = employeeList.OrderBy(x => x.HireDate).ToList();
            salesEmployeeList = salesEmployeeList.OrderBy(z => z.HireDate).ToList();
            employeeList.ForEach(x => Console.WriteLine(x));
            salesEmployeeList.ForEach(x => Console.WriteLine(x));
        }
    }
}