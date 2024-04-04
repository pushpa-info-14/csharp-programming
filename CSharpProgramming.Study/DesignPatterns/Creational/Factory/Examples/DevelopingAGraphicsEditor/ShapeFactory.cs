namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DevelopingAGraphicsEditor
{
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
}
