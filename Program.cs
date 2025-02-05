using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            DateTime dateTime = DateTime.Now;
            DayOfWeek dayOfWeek = dateTime.DayOfWeek;
            Console.WriteLine(dayOfWeek.ToString());
        }
    }
}