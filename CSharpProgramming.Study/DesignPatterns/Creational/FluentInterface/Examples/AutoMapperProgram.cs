using AutoMapper;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples
{
    public class AutoMapperProgram
    {
        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public class CustomerDto
        {
            public string FullName { get; set; }
        }

        public static class MapperConfig
        {
            public static Mapper InitializeAutoMapper()
            {
                // Provide all the Mapping Configuration
                var config = new MapperConfiguration(cfg =>
                {
                    // Configuring Employee and EmployeeDTO
                    cfg.CreateMap<Customer, CustomerDto>()
                        .ForMember(dest => dest.FullName,
                            opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
                    // Any Other Mapping Configuration ....
                });

                // Create an Instance of Mapper and return that Instance
                var mapper = new Mapper(config);
                return mapper;
            }
        }

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
