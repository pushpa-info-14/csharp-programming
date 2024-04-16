namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.AutoMapperImplementationUsingFluentInterface
{
    public class AutoMapperProgram
    {
        public void Test()
        {
            var customer = new Customer { FirstName = "John", LastName = "Doe" };

            // Initializing AutoMapper
            var mapper = MapperConfig.InitializeAutoMapper();
            // Way1: Specify the Destination Type and to The Map Method pass the Source Object
            var customerDto1 = mapper.Map<CustomerDto>(customer);
            Console.WriteLine(customerDto1.FullName); // Outputs: John Doe

            // Way2: Specify the both Source and Destination Type 
            // and to The Map Method pass the Source Object
            var customerDto2 = mapper.Map<Customer, CustomerDto>(customer);
            Console.WriteLine(customerDto2.FullName); // Outputs: John Doe
        }
    }
}
