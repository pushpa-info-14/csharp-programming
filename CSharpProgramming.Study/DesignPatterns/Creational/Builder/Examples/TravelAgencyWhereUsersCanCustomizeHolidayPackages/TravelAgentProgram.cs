namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.TravelAgencyWhereUsersCanCustomizeHolidayPackages
{
    public class TravelAgentProgram
    {
        public void Test()
        {
            var travelAgent = new TravelAgent();
            var packageBuilder = new CustomHolidayPackageBuilder();

            travelAgent.CreatePackage(packageBuilder, true, true, false, new[] { "Beach trip", "Mountain hiking" });

            var holidayPackage = packageBuilder.GetPackage();
            holidayPackage.DisplayPackageDetails();
        }
    }
}
