namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class PayPalPaymentFactory : IPaymentFactory
    {
        public IPaymentAuthorization CreateAuthorization() => new PayPalAuthorization();
        public IPaymentTransfer CreateTransfer() => new PayPalTransfer();
    }
}
