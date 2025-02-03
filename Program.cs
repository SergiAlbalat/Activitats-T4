using System;
using System.Collections;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInstructions = "Write the name and the age of 4 persons and i will print them";
            const string MsgFormatError = "The format of the input is incoorect";
            Console.WriteLine(MsgInstructions);
            Dictionary<string, int> diccionari = new Dictionary<string, int>();
            try
            {
                diccionari.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                diccionari.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                diccionari.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                diccionari.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                foreach(var item in diccionari)
                {
                    Console.WriteLine($"{item.Key}, {item.Value}");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine(MsgFormatError);
            }
            
        }
    }
}