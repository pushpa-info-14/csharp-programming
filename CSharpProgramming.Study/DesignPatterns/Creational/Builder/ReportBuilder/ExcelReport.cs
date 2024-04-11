﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.ReportBuilder;

// The Following Concrete Builder Implemented the ReportBuilder Abstract Class and 
// provide specific implementations of the steps for Creating ExcelReport. 
public class ExcelReport : ReportBuilder
{
    public override void SetReportContent()
    {
        reportObject.ReportContent = "Excel Content Section";
    }
    public override void SetReportFooter()
    {
        reportObject.ReportFooter = "Excel Footer";
    }
    public override void SetReportHeader()
    {
        reportObject.ReportHeader = "Excel Header";
    }
    public override void SetReportType()
    {
        reportObject.ReportType = "Excel";
    }
}