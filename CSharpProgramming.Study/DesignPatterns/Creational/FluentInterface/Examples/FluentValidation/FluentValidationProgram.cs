using FluentValidation;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentValidation
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
    }
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Please specify a first name")
                .Length(0, 10).WithMessage("First name cannot be longer than 10 characters");
            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Please specify a last name");
            RuleFor(x => x.Age)
                .InclusiveBetween(0, 150).WithMessage("Age must be between 0 and 150");
        }
    }
    public class FluentValidationProgram
    {
        public void Test()
        {
            var person = new Person
            {
                FirstName = "Johnathon",
                LastName = "",
                Age = 200
            };
            var validator = new PersonValidator();
            var results = validator.Validate(person);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine($"Property {failure.PropertyName} failed validation. Error was: {failure.ErrorMessage}");
                }
            }
        }
    }
}
