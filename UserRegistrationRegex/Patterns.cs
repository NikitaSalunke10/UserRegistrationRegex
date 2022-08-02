﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Patterns
    {
        public static string NameRule = "^[A-Z][a-z]{3,}$";
        public static string EmailRule = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{2,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string MobileRule = "^[1-9]{2}[ ][0-9]{10}";
        public void validateFName(string FName)//this method is to check if First name is valid or not
        {
            if (Regex.IsMatch(FName, NameRule))
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
        public void validateEmail(string Email)//this method is to check if Email is valid or not
        {
            if (Regex.IsMatch(Email, EmailRule))
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
            if (Regex.IsMatch(Mobile, MobileRule))
            {
                Console.WriteLine("Mobile No: " + Mobile);
            }
            else
            {
                Console.WriteLine("Invalid Mobile No.");
            }
        }
    }
}
