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
            Console.WriteLine(MyMethods.ValidatePassword("Hola1234!"));
            Console.WriteLine(MyMethods.ValidatePassword("hola1234"));

        }
    }
}