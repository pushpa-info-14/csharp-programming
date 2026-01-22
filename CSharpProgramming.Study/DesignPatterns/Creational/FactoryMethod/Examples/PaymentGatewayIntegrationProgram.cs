namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples;

public class PaymentGatewayIntegrationProgram
{
	// Product(Interface)
	public interface IPaymentGateway
	{
		void ProcessPayment(decimal amount);
	}

	// Concrete Products
	public class CreditCardPaymentGateway : IPaymentGateway
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing credit card payment of amount: ${amount}");
			// Actual logic to process credit card payment...
		}
	}

	public class PayPalPaymentGateway : IPaymentGateway
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing PayPal payment of amount: ${amount}");
			// Actual logic to process PayPal payment...
		}
	}

	public class BitcoinPaymentGateway : IPaymentGateway
	{
		public void ProcessPayment(decimal amount)
		{
			Console.WriteLine($"Processing Bitcoin payment of amount: ${amount}");
			// Actual logic to process Bitcoin payment...
		}
	}

	// Creator(Abstract Class)
	public abstract class PaymentGatewayFactory
	{
		public abstract IPaymentGateway CreatePaymentGateway();
	}

	// Concrete Creators
	public class CreditCardPaymentGatewayFactory : PaymentGatewayFactory
	{
		public override IPaymentGateway CreatePaymentGateway()
		{
			return new CreditCardPaymentGateway();
		}
	}

	public class PayPalPaymentGatewayFactory : PaymentGatewayFactory
	{
		public override IPaymentGateway CreatePaymentGateway()
		{
			return new PayPalPaymentGateway();
		}
	}

	public class BitcoinPaymentGatewayFactory : PaymentGatewayFactory
	{
		public override IPaymentGateway CreatePaymentGateway()
		{
			return new BitcoinPaymentGateway();
		}
	}

	// Client Code
	public class ECommercePlatform
	{
		public void Checkout(PaymentGatewayFactory factory, decimal amount)
		{
			IPaymentGateway paymentGateway = factory.CreatePaymentGateway();
			paymentGateway.ProcessPayment(amount);
		}
	}

	public static void Test()
	{
		var platform = new ECommercePlatform();

		// User selects Credit Card as the payment method:
		platform.Checkout(new CreditCardPaymentGatewayFactory(), 100.50M);

		// User selects PayPal as the payment method:
		platform.Checkout(new PayPalPaymentGatewayFactory(), 150.75M);

		// User selects Bitcoin as the payment method:
		platform.Checkout(new BitcoinPaymentGatewayFactory(), 50.30M);
	}
}
