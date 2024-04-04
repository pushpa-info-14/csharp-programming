namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.DevelopingAGraphicsEditor
{
    public class ShapeProgram
    {
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
