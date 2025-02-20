using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
namespace Activitats_T4
{ 
    public class Program
    {
        public delegate int MyDelegate(int a, int b);
        public static int MetodeAnonim(MyDelegate delegat)
        {
            return delegat(2, 4);
        }
        public static void Main()
        {
            MyDelegate metodeAnonim = delegate (int a, int b)
            {
                int num = 1;
                for (int i = 0; i < b; i++)
                {
                    num *= a;
                }
                return num;
            };
            Console.WriteLine(num);
        }
    }
}
