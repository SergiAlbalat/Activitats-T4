using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            List<int> numList = new List<int>() { 5, 10, 15, 20, 25 };
            numList.Add(30);
            numList.Insert(0, 7);
            numList.Sort();
            numList.RemoveAt(numList.BinarySearch(15));
            numList = numList.OrderByDescending(x => x).ToList();
            numList = numList.Where(n => n%2==0).ToList();
            numList.ForEach(x => Console.WriteLine(x));
        }
    }
}