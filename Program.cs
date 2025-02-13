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
        public static int ExecutarOperacio(int a, int b, MyDelegate op) => op(a, b);
        public static void Main()
        {
            Console.WriteLine(ExecutarOperacio(3, 3, Multiplicar));
            Console.WriteLine(ExecutarOperacio(20, 4, Dividir));
        }
    }
}