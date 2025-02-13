using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{
    public class Program
    {
        public delegate void Notificacio(string msg);
        public static void MostrarMissatgeConsola(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void MostrarMissatgeAmbEstrelles(string msg)
        {
            Console.WriteLine($"*{msg}*");
        }
        public static void Main()
        {
            Notificacio delegat = MostrarMissatgeConsola;
            delegat += MostrarMissatgeAmbEstrelles;
            delegat("Hello World");
        }
    }
}