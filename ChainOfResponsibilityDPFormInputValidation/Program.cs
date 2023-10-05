// Setup validation chain
using ChainOfResponsibilityDPFormInputValidation;

var nonEmptyValidator = new NonEmptyValidator();
var emailValidator = new EmailFormatValidator();
var passwordValidator = new PasswordStrengthValidator();
nonEmptyValidator.SetNext(emailValidator);
emailValidator.SetNext(passwordValidator);
// Sample input
var userInput = new UserInput
{
    Email = "pranaya.rout@dotnettutorials.net",
    Password = "StrongPass123"
};
if (nonEmptyValidator.Validate(userInput))
{
    Console.WriteLine("Registration Successful!");
}
else
{
    Console.WriteLine("Validation Failed!");
}
var userInput2 = new UserInput
{
    Email = "pranaya.rout",
    Password = "StrongPass123"
};
if (nonEmptyValidator.Validate(userInput2))
{
    Console.WriteLine("Registration Successful!");
}
else
{
    Console.WriteLine("Validation Failed!");
}
Console.ReadLine();