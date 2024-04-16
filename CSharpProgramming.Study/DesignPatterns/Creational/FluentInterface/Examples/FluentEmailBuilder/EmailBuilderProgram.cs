namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentEmailBuilder
{
    public class EmailBuilderProgram
    {
        public void Test()
        {
            var email = new EmailBuilder()
                .From("admin@dotnettutorials.net")
                .To("user1@dotnettutorials.net")
                .To("user2@dotnettutorials.net")
                .WithSubject("Welcome to Fluent Builder!")
                .WithBody("This is an example of the Fluent Interface Design Pattern in C#.")
                .Send();
        }
    }
}
