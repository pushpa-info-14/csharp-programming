﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples
{
    public class UserProfileBuilderProgram
    {
        public class UserProfile
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

            public string StreetAddress { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }

            public bool IsSubscribedToNewsletter { get; set; }
            public string ThemePreference { get; set; }

            public void DisplayProfile()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Address: {StreetAddress}, {City}, {State} {ZipCode}");
                Console.WriteLine($"Newsletter: {IsSubscribedToNewsletter}");
                Console.WriteLine($"Theme: {ThemePreference}");
            }
        }

        public abstract class UserProfileBuilder
        {
            protected UserProfile UserProfile { get; } = new();

            public abstract void SetBasicInfo(string firstName, string lastName, string email);
            public abstract void SetAddress(string street, string city, string state, string zip);
            public abstract void SetPreferences(bool newsletter, string theme);

            public UserProfile GetUserProfile() => UserProfile;
        }

        public class ConcreteUserProfileBuilder : UserProfileBuilder
        {
            public override void SetBasicInfo(string firstName, string lastName, string email)
            {
                UserProfile.FirstName = firstName;
                UserProfile.LastName = lastName;
                UserProfile.Email = email;
            }

            public override void SetAddress(string street, string city, string state, string zip)
            {
                UserProfile.StreetAddress = street;
                UserProfile.City = city;
                UserProfile.State = state;
                UserProfile.ZipCode = zip;
            }

            public override void SetPreferences(bool newsletter, string theme)
            {
                UserProfile.IsSubscribedToNewsletter = newsletter;
                UserProfile.ThemePreference = theme;
            }
        }

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
