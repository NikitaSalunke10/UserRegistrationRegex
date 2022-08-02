using UserRegistrationRegex;

Patterns pattern = new Patterns();
Console.WriteLine("Enter the First Name: ");
string FName = Console.ReadLine();
pattern.validateFName(FName);