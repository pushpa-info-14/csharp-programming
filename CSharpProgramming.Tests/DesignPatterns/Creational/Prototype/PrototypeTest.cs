using CSharpProgramming.Study.DesignPatterns.Creational.Prototype;
using CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Prototype
{
    public class PrototypeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("\n---- ObjectAssignmentExample");
            new ObjectAssignmentExample().Test();

            Console.WriteLine("\n---- ShallowCopyExample");
            new ShallowCopyExample().Test();

            Console.WriteLine("\n---- EmployeeProgram");
            new EmployeeProgram().Test();

            Console.WriteLine("\n---- ShallowAndDeepCopyProgram");
            new ShallowAndDeepCopyProgram().Test();

            Console.WriteLine("\n---- CarConfiguratorApplication");
            new CarConfiguratorApplication().Test();

            Console.WriteLine("\n---- FloorPlanDesign");
            new FloorPlanDesign().Test();

            Console.WriteLine("\n---- DocumentVersioningSystem");
            new DocumentVersioningSystem().Test();

            Console.WriteLine("\n---- EventManagement");
            new EventManagement().Test();

            Console.WriteLine("\n---- UserCustomizableGuiSystem");
            new UserCustomizableGuiSystem().Test();

            Console.WriteLine("\n---- GraphicsEditors");
            new GraphicsEditors().Test();

            Console.WriteLine("\n---- DatabaseRecordDuplication");
            new DatabaseRecordDuplication().Test();

            Console.WriteLine("\n---- GameDevelopment");
            new GameDevelopment().Test();

            Console.WriteLine("\n---- ConfigurationTemplates");
            new ConfigurationTemplates().Test();

            Console.WriteLine("\n---- HistoricalStatesForUndoActions");
            new HistoricalStatesForUndoActions().Test();
        }
    }
}
