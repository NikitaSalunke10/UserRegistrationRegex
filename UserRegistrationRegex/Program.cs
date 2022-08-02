using UserRegistrationRegex;

Patterns pattern = new Patterns();
Console.WriteLine("Enter the First Name: ");
string FName = Console.ReadLine();
<<<<<<< HEAD
pattern.validateFName(FName);
=======
Console.WriteLine("Enter the Last Name: ");
string LName = Console.ReadLine();
pattern.validateFName(FName);
pattern.validateLName(LName);
>>>>>>> UC-2-ValidLastName
