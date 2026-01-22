namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples;

public class PaymentGatewayProgram
{
	public interface IPaymentGateway
	{
		void ProcessPayment(decimal amount);
	}

	public class CreditCardGateway : IPaymentGateway
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing ${amount} payment using Credit Card...");
			// Logic for direct credit card processing
		}
	}

	public class PayPalGateway : IPaymentGateway
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing ${amount} payment through PayPal...");
			// Actual integration and logic for PayPal
		}
	}

	public class StripeGateway : IPaymentGateway
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing ${amount} payment through Stripe...");
			// Actual integration and logic for Stripe
		}
	}

	public static class PaymentGatewayFactory
	{
		public static IPaymentGateway CreatePaymentGateway(string gatewayName)
		{
			switch (gatewayName.ToLower())
			{
				case "paypal":
					return new PayPalGateway();
				case "stripe":
					return new StripeGateway();
				case "creditcard":
					return new CreditCardGateway();
				default:
					throw new ArgumentException("Invalid payment gateway specified");
			}
		}
	}

	public static void Test()
	{
		var paymentGateway = PaymentGatewayFactory.CreatePaymentGateway("PayPal");
		paymentGateway.ProcessPayment(100.00M);  // Example amount

		paymentGateway = PaymentGatewayFactory.CreatePaymentGateway("Stripe");
		paymentGateway.ProcessPayment(100.00M);  // Example amount

		paymentGateway = PaymentGatewayFactory.CreatePaymentGateway("CreditCard");
		paymentGateway.ProcessPayment(100.00M);  // Example amount
	}
}
