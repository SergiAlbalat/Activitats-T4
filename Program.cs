using System;
using System.Collections;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgFormatError = "The format of the name is incorrect";
            List<int> numberList = new List<int>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numberList.Add(int.Parse(Console.ReadLine()));
                }
                foreach (int i in numberList)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatError);
            }
        }
    }
}