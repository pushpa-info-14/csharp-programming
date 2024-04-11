﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.ReportBuilder;

// The Director is only responsible for executing the building steps in a particular order. 
// It is helpful when producing products according to a specific order or configuration. 
public class ReportDirector
{
    public Report MakeReport(ReportBuilder reportBuilder)
    {
        reportBuilder.CreateNewReport();
        reportBuilder.SetReportType();
        reportBuilder.SetReportHeader();
        reportBuilder.SetReportContent();
        reportBuilder.SetReportFooter();
        return reportBuilder.GetReport();
    }
}