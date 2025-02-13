using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{
    public class Program
    {
        public delegate int MyDelegate(int a, int b);
        public static int Multiplicar(int a, int b) => a * b;
        public static int Dividir(int a, int b) => a / b;
        public static void Main()
        {
            MyDelegate delegat = Multiplicar;
            Console.WriteLine(delegat(2, 4));
            delegat = Dividir;
            Console.WriteLine(delegat(10, 5));
        }
    }
}