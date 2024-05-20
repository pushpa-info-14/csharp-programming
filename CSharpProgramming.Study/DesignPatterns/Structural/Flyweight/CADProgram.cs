namespace CSharpProgramming.Study.DesignPatterns.Structural.Flyweight
{
    public class CADProgram
    {
        // Flyweight: ShapeStyle holds the shared properties
        public class ShapeStyle
        {
            public string Color { get; }
            public string Pattern { get; }
            public int Thickness { get; }

            public ShapeStyle(string color, string pattern, int thickness)
            {
                Color = color;
                Pattern = pattern;
                Thickness = thickness;
            }

            public void DisplayProperties()
            {
                Console.WriteLine($"Style [Color: {Color}, Pattern: {Pattern}, Thickness: {Thickness}]");
            }
        }

        // Flyweight Factory
        public class StyleFactory
        {
            private readonly Dictionary<string, ShapeStyle> _styles = new();

            public ShapeStyle GetStyle(string color, string pattern, int thickness)
            {
                var key = $"{color}_{pattern}_{thickness}";

                if (!_styles.ContainsKey(key))
                {
                    _styles[key] = new ShapeStyle(color, pattern, thickness);
                }

                return _styles[key];
            }
        }

        // The ConcreteFlyweight class with external states.
        public class Circle
        {
            private readonly ShapeStyle _style;
            public int X { get; }
            public int Y { get; }
            public int Radius { get; }

            public Circle(int x, int y, int radius, ShapeStyle style)
            {
                X = x;
                Y = y;
                Radius = radius;
                _style = style;
            }

            public void Draw()
            {
                Console.WriteLine($"Drawing Circle at ({X}, {Y}) with Radius {Radius}");
                _style.DisplayProperties();
            }
        }

        // Client
        class CADSystem
        {
            private readonly List<Circle> _circles = new List<Circle>();
            private readonly StyleFactory _styleFactory = new StyleFactory();

            public void AddCircle(int x, int y, int radius, string color, string pattern, int thickness)
            {
                var style = _styleFactory.GetStyle(color, pattern, thickness);
                _circles.Add(new Circle(x, y, radius, style));
            }

            public void DrawAllShapes()
            {
                foreach (var circle in _circles)
                {
                    circle.Draw();
                }
            }
        }

        public void Test()
        {
            var cadSystem = new CADSystem();

            cadSystem.AddCircle(5, 5, 10, "Red", "Solid", 2);
            cadSystem.AddCircle(15, 15, 20, "Blue", "Dotted", 3);
            cadSystem.AddCircle(25, 25, 30, "Red", "Solid", 2);

            cadSystem.DrawAllShapes();
        }
    }
}
