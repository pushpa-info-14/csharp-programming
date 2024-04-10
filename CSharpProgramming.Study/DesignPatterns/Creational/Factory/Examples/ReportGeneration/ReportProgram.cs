﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.ReportGeneration
{
    public class ReportProgram
    {
        public void Test()
        {
            var reportGenerator = ReportFactory.CreateReport("sales");
            reportGenerator.GenerateReport();

            reportGenerator = ReportFactory.CreateReport("inventory");
            reportGenerator.GenerateReport();

            reportGenerator = ReportFactory.CreateReport("hr");
            reportGenerator.GenerateReport();
        }
    }
}