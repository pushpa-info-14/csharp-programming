namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public interface IPaymentFactory
    {
        IPaymentAuthorization CreateAuthorization();
        IPaymentTransfer CreateTransfer();
    }
}
