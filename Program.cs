using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{ 
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(MyMethods.IsValidPhone("+34 600 123 456"));
            Console.WriteLine(MyMethods.IsValidPhone("60012345"));
        }
    }
}