using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{ 
    public class Program
    {
        public static void Main()
        {
            string msg = "Ha corregut 10km";
            List<int> numList = new List<int>();
            numList = MyMethods.ExtractNumbers(msg);
            numList.ForEach(num => Console.WriteLine(num));
        }
    }
}