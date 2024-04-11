namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.TravelAgencyWhereUsersCanCustomizeHolidayPackages;

public class TravelAgent
{
    public void CreatePackage(HolidayPackageBuilder builder, bool wantsFlight, bool wantsHotel, bool wantsCar, IEnumerable<string> excursions)
    {
        if (wantsFlight) builder.BookFlight("Flight details...");
        if (wantsHotel) builder.BookHotel("Fancy Hotel");
        if (wantsCar) builder.RentCar("SUV Model XYZ");
        foreach (var excursion in excursions)
        {
            builder.AddExcursion(excursion);
        }
    }
}