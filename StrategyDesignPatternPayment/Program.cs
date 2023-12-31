﻿namespace StrategyDesignPatternPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to Select the Payment Type
            Console.WriteLine("Please Select Payment Type : \n1 For CreditCard \n2 For DebitCard \n3 For Cash");
            int SelectedPaymentType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Payment type is : " + SelectedPaymentType);
            Console.WriteLine("\nPlease enter Amount to Pay : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Amount is : " + Amount);
            //Create an Instance of the PaymentContext class
            PaymentContext context = new PaymentContext();
            //Based on the Payment Type Selected by user at Runtime,
            //Create the Appropriate Payment Strategy Instance and call the SetPaymentStrategy method
            if (SelectedPaymentType == (int)PaymentType.CreditCard)
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.DebitCard)
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.Cash)
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            else
            {
                Console.WriteLine("You Select an Invalid Option");
            }
            //Finally, call the Pay Method
            context.Pay(Amount);
            Console.ReadKey();
        }
    }
}