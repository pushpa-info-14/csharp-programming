using AutoMapper;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.AutoMapperImplementationUsingFluentInterface;

public class MapperConfig
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