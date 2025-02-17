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
            Func<int, int, int> restar = (a, b) => a - b;
            Console.WriteLine(restar(5, 1));
            Console.WriteLine(restar(8, 3));
        }
    }
}