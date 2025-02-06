using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            DateTime fechaNacimiento = new DateTime(2006,02,18);
            Employee emp = new Employee();
            Console.WriteLine(emp.CalculateAge(fechaNacimiento));
        }
    }
}