namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples
{
    public class GraphicsEditors
    {
        // Prototype - IShapePrototype Interface
        public interface IShapePrototype
        {
            IShapePrototype Clone();
        }

        // Concrete Prototype - Circle Class
        public class Circle : IShapePrototype
        {
            public int X { get; set; }  // X-coordinate of the circle's center
            public int Y { get; set; }  // Y-coordinate of the circle's center
            public int Radius { get; set; }
            public string Color { get; set; }

            public IShapePrototype Clone()
            {
                return new Circle
                {
                    X = X,
                    Y = Y,
                    Radius = Radius,
                    Color = Color
                };
            }

            public void Display()
            {
                Console.WriteLine($"Circle at ({X}, {Y}) | Radius: {Radius} | Color: {Color}");
            }
        }

        // Client Code
        public void Test()
        {
            // User creates a circle in the graphics editor
            var originalCircle = new Circle
            {
                X = 5,
                Y = 5,
                Radius = 10,
                Color = "Red"
            };

            Console.WriteLine("Original Circle:");
            originalCircle.Display();

            // The user decides to clone the circle and place it at a different location
            var clonedCircle = (Circle)originalCircle.Clone();
            clonedCircle.X = 20;
            clonedCircle.Y = 20;

            Console.WriteLine("Cloned Circle with Different Position:");
            clonedCircle.Display();
        }
    }
}
