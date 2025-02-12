using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, double> employeeInfo = new Dictionary<string, double>();
            employeeInfo.Add("Marcos", 1001.43);
            employeeInfo.Add("Ruben", 435.12);
            employeeInfo.Add("Sans", 1.1);
            foreach(var employee in employeeInfo)
            {
                Console.WriteLine($"{employee.Key}: {employee.Value}");
            }
        }
    }
}