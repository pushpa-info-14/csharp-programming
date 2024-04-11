namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingComplexProfileObjectsForAUserRegistrationSystem;

public abstract class UserProfileBuilder
{
    protected UserProfile UserProfile { get; } = new();

    public abstract void SetBasicInfo(string firstName, string lastName, string email);
    public abstract void SetAddress(string street, string city, string state, string zip);
    public abstract void SetPreferences(bool newsletter, string theme);

    public UserProfile GetUserProfile() => UserProfile;
}