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
            Func<int, int, int> multiplicacio = (x, y) => x * y;
            Console.WriteLine(multiplicacio(4, 3));
            Action<int, int> mostrarSuma = (x, y) => Console.WriteLine(x + y);
            mostrarSuma(1, 7);
        }
    }
}