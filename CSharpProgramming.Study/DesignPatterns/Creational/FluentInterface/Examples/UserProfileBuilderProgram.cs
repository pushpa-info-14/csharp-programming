namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples
{
    public class UserProfileBuilderProgram
    {
        public class UserProfile
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Bio { get; set; }
            public List<string> Interests { get; } = new();
            public Dictionary<string, string> SocialLinks { get; } = new();
        }

        public class UserProfileBuilder
        {
            private readonly UserProfile _profile = new();

            public UserProfileBuilder Named(string name)
            {
                _profile.Name = name;
                return this;
            }

            public UserProfileBuilder WithEmail(string email)
            {
                _profile.Email = email;
                return this;
            }

            public UserProfileBuilder WithBio(string bio)
            {
                _profile.Bio = bio;
                return this;
            }

            public UserProfileBuilder AddInterest(string interest)
            {
                _profile.Interests.Add(interest);
                return this;
            }

            public UserProfileBuilder WithSocialLink(string platform, string link)
            {
                _profile.SocialLinks[platform] = link;
                return this;
            }

            public UserProfile Build()
            {
                return _profile;
            }
        }

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
