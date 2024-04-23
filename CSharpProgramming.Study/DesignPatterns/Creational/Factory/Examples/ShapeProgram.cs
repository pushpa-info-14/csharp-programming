namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples
{
    public class ShapeProgram
    {
        public interface IShape
        {
            void Draw();
        }

        public class Circle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Circle!");
            }
        }

        public class Rectangle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Rectangle!");
            }
        }

        public class Triangle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a Triangle!");
            }
        }

        public static class ShapeFactory
        {
            public static IShape CreateShape(string shapeType)
            {
                switch (shapeType.ToLower())
                {
                    case "circle":
                        return new Circle();
                    case "rectangle":
                        return new Rectangle();
                    case "triangle":
                        return new Triangle();
                    default:
                        throw new ArgumentException("Invalid shape type");
                }
            }
        }

        public void Test()
        {
            var chosenShape = ShapeFactory.CreateShape("circle");
            chosenShape.Draw();

            chosenShape = ShapeFactory.CreateShape("rectangle");
            chosenShape.Draw();

            chosenShape = ShapeFactory.CreateShape("triangle");
            chosenShape.Draw();
        }
    }
}
