using System;
using System.Collections;
using System.Runtime.CompilerServices;
namespace Activitats_T4
{
    public class Program
    {
        public static void Main()
        {
            const string MsgSearchName = "What name do you want to search in the dictionary?";
            const string MsgNameFound = "It's in the dictionary!";
            const string MsgNameNotFound = "It's not in the dictionary!";
            const string MsgNageAge = "The age of {0} is: {1}";
            const string MsgFormatError = "The format of the name is incorrect";
            string searchKey;
            Dictionary<string, int> studentAges = new Dictionary<string, int>();
            studentAges.Add("Marc", 21);
            studentAges.Add("Laura", 19);
            studentAges.Add("Pau", 22);
            foreach(var i in studentAges)
            {
                Console.WriteLine("{0}: {1}", i.Key, i.Value);
            }
            Console.WriteLine(MsgSearchName);
            try
            {
                searchKey = Console.ReadLine();
                Console.WriteLine(studentAges.ContainsKey(searchKey));
                if (studentAges.ContainsKey(searchKey)){
                    Console.WriteLine(MsgNageAge, searchKey, studentAges[searchKey]);
                }
                studentAges.Remove("Laura");
                foreach (var i in studentAges)
                {
                    Console.WriteLine("{0}: {1}", i.Key, i.Value);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine(MsgFormatError);
            }
            
        }
    }
}