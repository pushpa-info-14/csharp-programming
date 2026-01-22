namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples;

public class ReportProgram
{
	public interface IReportGenerator
	{
		void GenerateReport();
	}

	public class SalesReport : IReportGenerator
	{
		public void GenerateReport()
		{
			Console.WriteLine("Generating Sales Report...");
			// Logic for generating sales report
		}
	}

	public class InventoryReport : IReportGenerator
	{
		public void GenerateReport()
		{
			Console.WriteLine("Generating Inventory Report...");
			// Logic for generating inventory report
		}
	}

	public class HrReport : IReportGenerator
	{
		public void GenerateReport()
		{
			Console.WriteLine("Generating HR Report...");
			// Logic for generating HR report
		}
	}

	public static class ReportFactory
	{
		public static IReportGenerator CreateReport(string reportType)
		{
			switch (reportType.ToLower())
			{
				case "sales":
					return new SalesReport();
				case "inventory":
					return new InventoryReport();
				case "hr":
					return new HrReport();
				default:
					throw new ArgumentException("Invalid report type");
			}
		}
	}

	public static void Test()
	{
		var reportGenerator = ReportFactory.CreateReport("sales");
		reportGenerator.GenerateReport();

		reportGenerator = ReportFactory.CreateReport("inventory");
		reportGenerator.GenerateReport();

		reportGenerator = ReportFactory.CreateReport("hr");
		reportGenerator.GenerateReport();
	}
}
