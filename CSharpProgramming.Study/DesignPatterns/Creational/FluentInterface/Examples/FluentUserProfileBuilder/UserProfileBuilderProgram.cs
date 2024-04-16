namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentUserProfileBuilder
{
    public class UserProfileBuilderProgram
    {
        public void Test()
        {
            var userProfile = new UserProfileBuilder()
                .Named("Pranaya Rout")
                .WithEmail("pranaya@dotnettutorials.com")
                .WithBio("Software Developer at XYZ.")
                .AddInterest("Coding")
                .AddInterest("Hiking")
                .WithSocialLink("Twitter", "https://twitter.com/RoutPranaya")
                .WithSocialLink("LinkedIn", "https://www.linkedin.com/in/pranaya-rout/")
                .Build();
            Console.WriteLine($"Name: {userProfile.Name}");
            Console.WriteLine($"Bio: {userProfile.Bio}");
            Console.WriteLine($"Interests: {string.Join(", ", userProfile.Interests)}");
            // And so on...
        }
    }
}
