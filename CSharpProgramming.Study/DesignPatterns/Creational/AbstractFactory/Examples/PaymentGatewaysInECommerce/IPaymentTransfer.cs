namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public interface IPaymentTransfer
    {
        bool Transfer(decimal amount);
    }
}
