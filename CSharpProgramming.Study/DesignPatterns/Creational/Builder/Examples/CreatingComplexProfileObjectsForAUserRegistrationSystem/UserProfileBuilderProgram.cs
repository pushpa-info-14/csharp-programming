namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.CreatingComplexProfileObjectsForAUserRegistrationSystem
{
    public class UserProfileBuilderProgram
    {
        public void Test()
        {
            var userProfileBuilder = new ConcreteUserProfileBuilder();

            userProfileBuilder.SetBasicInfo("John", "Doe", "john.doe@example.com");
            userProfileBuilder.SetAddress("123 Main St", "Springfield", "IL", "12345");
            userProfileBuilder.SetPreferences(true, "Dark");

            var userProfile = userProfileBuilder.GetUserProfile();
            userProfile.DisplayProfile();
        }
    }
}
