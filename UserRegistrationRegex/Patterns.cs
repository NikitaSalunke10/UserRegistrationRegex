using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class Patterns
    {
        public static string NameRule = "^[A-Z][a-z]{3,}$";
        public static string EmailRule = "^[a-zA-Z0-9]+([.+-_][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public static string MobileRule = "^[1-9]{2}[ ][0-9]{10}";
        public static string PasswordRule = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*#?&]).{8,}$";
        public bool FNameCheck, LNameCheck, MobileCheck, PasswordCheck, EmailCheck;
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            FNameCheck = Regex.IsMatch(FName, NameRule);
            if (FNameCheck)
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
            LNameCheck = Regex.IsMatch(LName, NameRule);
            if (LNameCheck)
            {
                Console.WriteLine("Last Name: " + LName);
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
        public void validateEmail(string Email)//this method is to check if Email is valid or not
        {
            EmailCheck = Regex.IsMatch(Email, EmailRule);
            if (EmailCheck)
            {
                Console.WriteLine("Email ID: " + Email);
            }
            else
            {
                Console.WriteLine("Invalid Email ID");
            }
        }
        public void validateMobile(string Mobile)//this method is to check if Mobile no is valid or not
        {
            MobileCheck = Regex.IsMatch(Mobile, MobileRule);
            if (MobileCheck)
            {
                Console.WriteLine("Mobile No: " + Mobile);
            }
            else
            {
                Console.WriteLine("Invalid Mobile No.");
            }
        }
        public void validatePassword(string Password)//this method is to check if Password is valid or not
        {
            PasswordCheck = Regex.IsMatch(Password, PasswordRule);
            if (PasswordCheck)
            {
                Console.WriteLine("Password: " + Password);
            }
            else
            {
                Console.WriteLine("Invalid Password.");
            }
        }
    }
}
