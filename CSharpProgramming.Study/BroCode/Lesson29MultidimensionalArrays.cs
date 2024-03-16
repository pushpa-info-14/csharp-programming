namespace CSharpProgramming.Study.BroCode
{
    public class Lesson29MultidimensionalArrays
    {
        public void Method1()
        {
            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "Corvette", "Camaro", "Silverado" };
            string[] toyota = { "Corolla", "Camry", "Rav4" };

            string[,] parkingLot =
            {
                { "Mustang", "F-150", "Explorer" },
                { "Corvette", "Camaro", "Silverado" },
                { "Corolla", "Camry", "Rav4" }
            };

            parkingLot[0, 2] = "Fusion";

            foreach (var car in parkingLot)
            {
                Console.WriteLine($"foreach: {car}");
            }

            for (var r = 0; r < parkingLot.GetLength(0); r++)
            {
                for (var c = 0; c < parkingLot.GetLength(1); c++)
                {
                    Console.WriteLine($"row: {r}, col: {c}, vehicle: {parkingLot[r, c]}");
                }
            }

            string[][] jaggedArray =
            {
                new []{ "Mustang", "F-150", "Explorer" },
                new []{ "Corvette", "Camaro", "Silverado" },
                new []{ "Corolla", "Camry", "Rav4" }
            };

            for (var r = 0; r < jaggedArray.Length; r++)
            {
                for (var c = 0; c < jaggedArray[0].Length; c++)
                {
                    Console.WriteLine($"row: {r}, col: {c}, vehicle: {parkingLot[r, c]}");
                }
            }
        }
    }
}
