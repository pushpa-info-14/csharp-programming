namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples
{
    public class TravelAgentProgram
    {
        public class HolidayPackage
        {
            public string Flight { get; set; }
            public string Hotel { get; set; }
            public string CarRental { get; set; }
            public List<string> Excursions { get; } = new();

            public void DisplayPackageDetails()
            {
                Console.WriteLine($"Flight: {Flight ?? "Not selected"}");
                Console.WriteLine($"Hotel: {Hotel ?? "Not selected"}");
                Console.WriteLine($"Car Rental: {CarRental ?? "Not selected"}");
                Console.WriteLine("Excursions: " + (Excursions.Any() ? string.Join(", ", Excursions) : "No excursions selected"));
            }
        }

        public abstract class HolidayPackageBuilder
        {
            protected HolidayPackage Package { get; } = new();

            public abstract void BookFlight(string flightDetails);
            public abstract void BookHotel(string hotelName);
            public abstract void RentCar(string carDetails);
            public abstract void AddExcursion(string excursion);

            public HolidayPackage GetPackage() => Package;
        }

        public class CustomHolidayPackageBuilder : HolidayPackageBuilder
        {
            public override void BookFlight(string flightDetails)
            {
                Package.Flight = flightDetails;
            }

            public override void BookHotel(string hotelName)
            {
                Package.Hotel = hotelName;
            }

            public override void RentCar(string carDetails)
            {
                Package.CarRental = carDetails;
            }

            public override void AddExcursion(string excursion)
            {
                Package.Excursions.Add(excursion);
            }
        }

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
