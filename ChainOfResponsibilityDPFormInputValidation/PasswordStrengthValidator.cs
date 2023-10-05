namespace ChainOfResponsibilityDPFormInputValidation
{
    public class PasswordStrengthValidator : ValidationHandler
    {
        public override bool Validate(UserInput input)
        {
            if (input.Password.Length < 8 || !input.Password.Any(char.IsUpper) ||
                !input.Password.Any(char.IsLower) || !input.Password.Any(char.IsDigit))
            {
                Console.WriteLine("Weak password. Ensure it's at least 8 characters and contains uppercase, lowercase, and a digit.");
                return false;
            }
            return nextHandler?.Validate(input) ?? true;
        }
    }
}
