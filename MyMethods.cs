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

        public static bool IsValidPhone(string number)
        {
            if(Regex.IsMatch(number, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$"))
            {
                return true;
            }else if(Regex.IsMatch(number, @"^\+34 [0-9][0-9][0-9] [0-9][0-9][0-9] [0-9][0-9][0-9]$")){
                return true;
            }else if(Regex.IsMatch(number, @"^[0-9][0-9][0-9] [0-9][0-9][0-9] [0-9][0-9][0-9]$")){
                return true;
            }
            return false;
        }

        public static List<int> ExtractNumbers(string input)
        {
            List<int> numList = new List<int>();
            
            numList.Add(int.Parse(Regex.Match(input, @"\d+").Value));
            return numList;
        }

        public static bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{7,}$");
        }
    }
}
