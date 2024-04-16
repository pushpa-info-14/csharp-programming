namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentValidation
{
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
