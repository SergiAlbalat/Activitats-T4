using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInstructions = "Enter a date and i will tell you how much time is left (Format: YYYY-MM-DD)";
            const string MsgFormatError = "The format of the name is incorrect";
            Console.WriteLine(MsgInstructions);
            try
            {
                DateTime dateTime = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                TimeSpan diferencia = dateTime.Subtract(DateTime.Now);
                Console.WriteLine(diferencia);
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatError);
            }
        }
    }
}