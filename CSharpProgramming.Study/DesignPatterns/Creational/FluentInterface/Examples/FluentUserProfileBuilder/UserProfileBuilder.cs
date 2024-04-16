namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentUserProfileBuilder;

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