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
            Console.WriteLine(MyMethods.IsValidEmail("sergialbalat@gmail.com"));
            Console.WriteLine(MyMethods.IsValidEmail("*@12"));
        }
    }
}