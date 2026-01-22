using CSharpProgramming.Study.DesignPatterns.O1_Creational.O6_Prototype;
using CSharpProgramming.Study.DesignPatterns.O1_Creational.O6_Prototype.Examples;
using Xunit;

namespace CSharpProgramming.Tests.DesignPatterns.Creational.Prototype;

public class PrototypeTest
{
	[Fact]
	public void Test1()
	{
		Console.WriteLine("\n---- ObjectAssignmentExample");
		ObjectAssignmentExample.Test();

		Console.WriteLine("\n---- ShallowCopyExample");
		ShallowCopyExample.Test();

		Console.WriteLine("\n---- EmployeeProgram");
		EmployeeProgram.Test();

		Console.WriteLine("\n---- ShallowAndDeepCopyProgram");
		ShallowAndDeepCopyProgram.Test();

		Console.WriteLine("\n---- CarConfiguratorApplication");
		CarConfiguratorApplication.Test();

		Console.WriteLine("\n---- FloorPlanDesign");
		FloorPlanDesign.Test();

		Console.WriteLine("\n---- DocumentVersioningSystem");
		DocumentVersioningSystem.Test();

		Console.WriteLine("\n---- EventManagement");
		EventManagement.Test();

		Console.WriteLine("\n---- UserCustomizableGuiSystem");
		UserCustomizableGuiSystem.Test();

		Console.WriteLine("\n---- GraphicsEditors");
		GraphicsEditors.Test();

		Console.WriteLine("\n---- DatabaseRecordDuplication");
		DatabaseRecordDuplication.Test();

		Console.WriteLine("\n---- GameDevelopment");
		GameDevelopment.Test();

		Console.WriteLine("\n---- ConfigurationTemplates");
		ConfigurationTemplates.Test();

		Console.WriteLine("\n---- HistoricalStatesForUndoActions");
		HistoricalStatesForUndoActions.Test();
	}
}
