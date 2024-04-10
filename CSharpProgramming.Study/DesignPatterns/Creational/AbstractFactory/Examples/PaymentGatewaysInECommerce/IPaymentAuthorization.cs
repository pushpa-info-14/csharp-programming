namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public interface IPaymentAuthorization
    {
        bool AuthorizePayment(decimal amount);
    }
}
