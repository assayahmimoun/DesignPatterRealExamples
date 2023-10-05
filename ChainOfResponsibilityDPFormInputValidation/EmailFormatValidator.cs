using System.Text.RegularExpressions;

namespace ChainOfResponsibilityDPFormInputValidation
{
    public class EmailFormatValidator : ValidationHandler
    {
        public override bool Validate(UserInput input)
        {
            // Regex for email validation.
            bool IsValidEmail = Regex.IsMatch(input.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!IsValidEmail)
            {
                Console.WriteLine("Invalid Email Format.");
                return false;
            }
            return nextHandler?.Validate(input) ?? true;
        }
    }
}
