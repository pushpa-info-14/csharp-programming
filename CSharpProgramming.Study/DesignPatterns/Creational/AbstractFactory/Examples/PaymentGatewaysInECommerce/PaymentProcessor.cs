namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.PaymentGatewaysInECommerce
{
    public class PaymentProcessor
    {
        private readonly IPaymentAuthorization _authorization;
        private readonly IPaymentTransfer _transfer;
        public PaymentProcessor(IPaymentFactory factory)
        {
            _authorization = factory.CreateAuthorization();
            _transfer = factory.CreateTransfer();
        }
        public bool ProcessPayment(decimal amount)
        {
            if (_authorization.AuthorizePayment(amount))
            {
                return _transfer.Transfer(amount);
            }
            return false;
        }
    }
}
