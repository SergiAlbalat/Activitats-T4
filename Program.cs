using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            List<int> numList = new List<int> { 1, 2, 3, 10 };
            int sum = numList.Sum();
            Console.WriteLine(sum);
        }
    }
}