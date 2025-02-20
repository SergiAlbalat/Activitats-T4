using System;
using System.IO;
using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{ 
    public class Program
    {
        public static void Main()
        {
            string path = "notes.txt";
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("4.9,Alejandro,Martin,Esteve");
                sw.WriteLine("10,Sergi,Albalat,Duran");
                sw.WriteLine("8.5,Marcos,Barrero,Herrero");
                sw.WriteLine("7,Ruben,Borrego,Gomez");
                sw.WriteLine("5,Pol,Guerrero,Muñoz");
            }
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}