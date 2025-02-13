using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInstructions = "Write a number and i will remove from the list all the numbers above it\nList:";
            const string MsgResult = "The final list is:";
            int num;
            Console.WriteLine(MsgInstructions);
            List<int> numList = new List<int>() { 3, 12, 26, 33, 40, 43, 56 };
            numList.ForEach(num => Console.WriteLine(num));
            try
            {
                num = MyMethods.GetNumber();
                numList = numList.Where(n => n < num).ToList();
                Console.WriteLine(MsgResult);
                numList.ForEach(num => Console.WriteLine(num));
            }catch(FormatException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}