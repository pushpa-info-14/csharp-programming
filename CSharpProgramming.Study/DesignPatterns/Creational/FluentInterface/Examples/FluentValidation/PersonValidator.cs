using FluentValidation;

namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentValidation;

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