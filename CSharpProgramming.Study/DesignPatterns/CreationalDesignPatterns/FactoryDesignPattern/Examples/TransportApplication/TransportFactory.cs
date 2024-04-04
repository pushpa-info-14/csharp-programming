namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.TransportApplication
{
    public static class TransportFactory
    {
        public static ITransport CreateTransport(string type)
        {
            switch (type.ToLower())
            {
                case "car":
                    return new Car();
                case "bus":
                    return new Bus();
                case "bike":
                    return new Bike();
                default:
                    throw new ArgumentException("Invalid transport type");
            }
        }
    }
}
