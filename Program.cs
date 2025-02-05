using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInstructions = "Enter two dates in DD-MM-YYYY and i will tell you if the second one is bigger tha the first one";
            const string MsgBigger = "The second date is bigger";
            const string MsgSmaller = "The second date is smaller";
            int day, month;
            Console.WriteLine(MsgInstructions);
            day = MyMethods.GetNumber();
            month = MyMethods.GetNumber();
            DateTime firstDate = new DateTime(MyMethods.GetNumber(), month, day);
            day = MyMethods.GetNumber();
            month = MyMethods.GetNumber();
            DateTime secondDate = new DateTime(MyMethods.GetNumber(), month, day);
            Console.WriteLine(DateTime.Compare(firstDate, secondDate) > 0 ? MsgSmaller : MsgBigger);
        }
    }
}