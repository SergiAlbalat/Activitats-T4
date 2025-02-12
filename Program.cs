using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            string[] words = new string[] { "hola", "adeu", "dasda", "JAJAJAJA" };
            List<string> wordList = words.ToList();
            wordList.ForEach(word => Console.WriteLine(word));
        }
    }
}