namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples
{
    public class FloorPlanDesign
    {
        // Prototype - IRoomPrototype Interface
        private interface IRoomPrototype
        {
            IRoomPrototype Clone();
        }

        // Concrete Prototype - Room Class
        private class Room : IRoomPrototype
        {
            public int NumberOfDoors { get; set; }
            public int NumberOfWindows { get; set; }
            public string FloorType { get; set; }
            public string WallColor { get; set; }

            public IRoomPrototype Clone()
            {
                // Using MemberwiseClone for simplicity, which is a shallow copy.
                return (IRoomPrototype)this.MemberwiseClone();
            }

            public override string ToString()
            {
                return $"Room with {NumberOfDoors} doors, {NumberOfWindows} windows, {FloorType} floor, and {WallColor} walls.";
            }
        }

        // Client Code
        public void Test()
        {
            // Standard room template
            var standardRoom = new Room
            {
                NumberOfDoors = 1,
                NumberOfWindows = 2,
                FloorType = "Hardwood",
                WallColor = "White"
            };

            Console.WriteLine("Standard Room:");
            Console.WriteLine(standardRoom);

            // Client wants a similar room but with tiles and an extra window.
            var customRoom = (Room)standardRoom.Clone();
            customRoom.FloorType = "Tiles";
            customRoom.NumberOfWindows = 3;

            Console.WriteLine("\nCustomized Room:");
            Console.WriteLine(customRoom);
        }
    }
}
