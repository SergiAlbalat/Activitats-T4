using System;
using System.Text.RegularExpressions;
namespace Activitats_T4
{
    public static class MyMethods
    {
        public static int GetNumber()
        {
            const string MsgFormatError = "The format of the number is incorrect";
            if(!int.TryParse(Console.ReadLine(), out int result))
            {
                throw new FormatException(MsgFormatError);
            }
            return result;
        }
        
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"(?i)^[A-Z1-9].*@[A-Z].*\.com$");
        }
    }
}
