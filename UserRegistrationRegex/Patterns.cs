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
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
        public void validateFName(string FName)
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
