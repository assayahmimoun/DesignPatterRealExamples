namespace ChainOfResponsibilityDPFormInputValidation
{
    //Concrete Handlers
    public class NonEmptyValidator : ValidationHandler
    {
        public override bool Validate(UserInput input)
        {
            if (string.IsNullOrWhiteSpace(input.Email) || string.IsNullOrWhiteSpace(input.Password))
            {
                Console.WriteLine("Fields Should Not Be Empty.");
                return false;
            }
            return nextHandler?.Validate(input) ?? true;
        }
    }
}
