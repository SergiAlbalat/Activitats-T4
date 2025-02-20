using System;
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
            const string MsgEvens = "Even Numbers: ";
            const string MsgPositive = "\nPositive Numbers: ";
            const string MsgBigNum = "\nBig numbers and their Square: ";
            const string MsgNumFrequency = "Frquency of each number:";
            const string MsgCharFrequency = "Frequency of each character of a string";
            List<int> numList = new List<int>() { 7,22,-3,-4,-5,6,7,78,49,-7 };
            string charChain = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque vel dolor quis nisi condimentum consequat. Suspendisse potenti.";
            List<int> modifiedList = numList.Where(x => x%2==0).ToList();
            Console.Write(MsgEvens);
            modifiedList.ForEach(num => Console.Write($"{num}, "));
            modifiedList = numList.Where(x => x>0).ToList();
            Console.Write(MsgPositive);
            modifiedList.ForEach(num => Console.Write($"{num}, "));
            modifiedList = numList.Where(x => x>20).ToList();
            Console.WriteLine(MsgBigNum);
            modifiedList.ForEach(num => Console.WriteLine($"{num}, {num*num}"));
            Console.WriteLine(MsgNumFrequency);
            foreach(int num in numList.Distinct())
            {
                Console.WriteLine($"{num}: {numList.Where(x => x == num).Count()}");
            }
            Console.WriteLine(MsgCharFrequency);
            foreach(char ch in charChain.Distinct())
            {
                Console.WriteLine($"{ch}: {charChain.Where(x => x == ch).Count()}");
            }
            var diesSetmana = CultureInfo.CurrentCulture.DateTimeFormat.DayNames.Select(x => x);
            foreach(var dia in diesSetmana)
            {
                Console.WriteLine(dia);
            }
        }
    }
}