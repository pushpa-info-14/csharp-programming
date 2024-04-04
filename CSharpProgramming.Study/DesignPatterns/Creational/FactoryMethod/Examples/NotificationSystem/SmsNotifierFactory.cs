namespace CSharpProgramming.Study.DesignPatterns.Creational.FactoryMethod.Examples.NotificationSystem
{
    public class SmsNotifierFactory : NotifierFactory
    {
        public override INotifier CreateNotifier()
        {
            return new SmsNotifier();
        }
    }
}
