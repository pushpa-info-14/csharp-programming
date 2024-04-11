namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.TravelAgencyWhereUsersCanCustomizeHolidayPackages;

public abstract class HolidayPackageBuilder
{
    protected HolidayPackage Package { get; } = new();

    public abstract void BookFlight(string flightDetails);
    public abstract void BookHotel(string hotelName);
    public abstract void RentCar(string carDetails);
    public abstract void AddExcursion(string excursion);

    public HolidayPackage GetPackage() => Package;
}