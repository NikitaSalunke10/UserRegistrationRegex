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
        public static string RegexRules = "^[A-Z][a-z]{3,}$"; 
        public bool validateString(string sample) //this method is used to check whether the input from user match with the regex rules written
        {
            return Regex.IsMatch(sample, RegexRules);
        }
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            if(validateString(FName))
            {
                Console.WriteLine("First Name: " + FName);
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
