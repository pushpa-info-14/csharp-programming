namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization() => new CreditCardAuthorization();
        public IPaymentTransfer CreateTransfer() => new CreditCardTransfer();
    }
}
