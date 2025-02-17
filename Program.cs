using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{ 
    public class Program
    {
        public delegate void Notificacio(string msg);
        public static void PrintMessage(Notificacio msg)
        {
            msg("MissatgeAnonim");
        }
        public static void Main()
        {
            PrintMessage(delegate (string msg) {
                Console.WriteLine(msg);
            });
        }
    }
}