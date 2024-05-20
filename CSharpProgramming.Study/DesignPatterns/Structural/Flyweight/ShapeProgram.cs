﻿namespace CSharpProgramming.Study.DesignPatterns.Structural.Flyweight
{
    public class ShapeProgram
    {
        // Flyweight Interface
        // This is an interface that defines the members of the flyweight objects.
        public interface IShape
        {
            void Draw();
        }

        // ConcreteFlyweight
        // This is a class which is Inherits from the Flyweight Interface.
        public class Circle : IShape
        {
            public string Color { get; set; }

            // The following Properties Values are going to be the same for all Circle Shape Object
            private readonly int _xCor = 10;
            private readonly int _yCor = 20;
            private readonly int _radius = 30;

            // For Each Circle Object, we need to call the Following Method to set the Color
            public void SetColor(string color)
            {
                Color = color;
            }

            public void Draw()
            {
                Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + _xCor + ", YCor :" + _yCor + ", Radius :" + _radius);
            }
        }

        // FlyweightFacory
        // This is a factory class used to create concrete objects of the ConcreteFlyweight type
        public class ShapeFactory
        {
            // The Following Dictionary is going to act as our Cache Memory
            private static readonly Dictionary<string, IShape> ShapeMap = new();

            // The following Method is going to return the Shape Object
            public static IShape GetShape(string shapeType)
            {
                IShape shape = null;
                if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
                {
                    // If the key shapeType i.e. circle is stored in the Cache, then return the value of the key
                    // else create circle object, store it in the Cache, and return the object
                    if (ShapeMap.TryGetValue("circle", out shape))
                    {
                    }
                    else
                    {
                        shape = new Circle();
                        ShapeMap.Add("circle", shape);
                        Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
                    }
                }
                return shape;
            }
        }

        public void Test()
        {
            // Creating Circle Objects with Red Color
            Console.WriteLine("\n Red color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Red");
                circle.Draw();
            }

            // Creating Circle Objects with Green Color
            Console.WriteLine("\n Green color Circles ");
            for (int i = 0; i < 3; i++)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Green");
                circle.Draw();
            }

            // Creating Circle Objects with Blue Color
            Console.WriteLine("\n Blue color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Green");
                circle.Draw();
            }

            // Creating Circle Objects with Orange Color
            Console.WriteLine("\n Orange color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Orange");
                circle.Draw();
            }

            // Creating Circle Objects with Black Color
            Console.WriteLine("\n Black color Circles");
            for (int i = 0; i < 3; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetShape("circle");
                circle.SetColor("Black");
                circle.Draw();
            }
        }
    }
}
