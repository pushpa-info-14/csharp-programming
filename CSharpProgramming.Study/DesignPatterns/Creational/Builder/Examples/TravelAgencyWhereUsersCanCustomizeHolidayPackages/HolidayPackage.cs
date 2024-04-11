namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.TravelAgencyWhereUsersCanCustomizeHolidayPackages;

public class HolidayPackage
{
    public string? Flight { get; set; }
    public string? Hotel { get; set; }
    public string? CarRental { get; set; }
    public List<string> Excursions { get; } = new();

    public void DisplayPackageDetails()
    {
        Console.WriteLine($"Flight: {Flight ?? "Not selected"}");
        Console.WriteLine($"Hotel: {Hotel ?? "Not selected"}");
        Console.WriteLine($"Car Rental: {CarRental ?? "Not selected"}");
        Console.WriteLine($"Excursions: " + (Excursions.Any() ? string.Join(", ", Excursions) : "No excursions selected"));
    }
}