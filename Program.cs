using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList() { "Maria", "Joan", "Anna", 42, true };
            foreach(var i in  arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.RemoveAt(4);
            arrayList.RemoveAt(3);
            arrayList.Insert(2, "Pere");
            arrayList.Sort();
            Console.WriteLine(arrayList.BinarySearch("Anna") == 0 ? "Anna es troba en l'ArrayList" : "Anna no es troba en l'ArrayList");
            arrayList.ToArray();
        }
    }
}