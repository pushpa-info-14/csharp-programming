namespace CSharpProgramming.Study.DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Examples.ReportGeneration
{
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
}
