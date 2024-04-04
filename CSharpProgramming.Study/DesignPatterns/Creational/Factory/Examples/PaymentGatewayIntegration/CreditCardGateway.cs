﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.PaymentGatewayIntegration
{
    public class CreditCardGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment using Credit Card...");
            // Logic for direct credit card processing
        }
    }
}
