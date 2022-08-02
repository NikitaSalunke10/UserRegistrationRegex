using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Patterns
    {
<<<<<<< HEAD
        public static string RegexRules = "^[A-Z][a-z]{3,}$"; 
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            if(Regex.IsMatch(FName,RegexRules))
=======
        public static string NameRule = "^[A-Z][a-z]{3,}$";
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            if (Regex.IsMatch(FName, NameRule))
>>>>>>> UC-2-ValidLastName
            {
                Console.WriteLine("First Name: " + FName);
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }

        public void validateLName(string LName)//this method is to check if Last name is valid or not
        {
            if (Regex.IsMatch(LName, NameRule))
            {
                Console.WriteLine("Last Name: " + LName);
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
