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
            Console.WriteLine(MyMethods.ValidatePostalCode("08001"));
            Console.WriteLine(MyMethods.ValidatePostalCode("60000"));
        }
    }
}