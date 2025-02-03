using System;
using System.Collections;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgInstructions = "Write 4 names and i will sort them";
            const string MsgFormatError = "The format of the name is incorrect";
            string[] names = new string[4];
            Console.WriteLine(MsgInstructions);
            try
            {
                for(int i = 0; i < names.Length; i++)
                {
                    names[i] = Console.ReadLine();
                }
                Console.WriteLine("--------------");
                for(int i = 0;i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.WriteLine("--------------");
                Array.Sort(names);
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(MsgFormatError);
            }
        }
    }
}