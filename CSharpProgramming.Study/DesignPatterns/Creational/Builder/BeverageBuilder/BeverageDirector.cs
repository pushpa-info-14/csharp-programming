﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.BeverageBuilder;

public class BeverageDirector
{
    public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
    {
        beverageBuilder.CreateBeverage();
        beverageBuilder.SetBeverageType();
        beverageBuilder.SetWater();
        beverageBuilder.SetMilk();
        beverageBuilder.SetSugar();
        beverageBuilder.SetPowderQuantity();

        return beverageBuilder.GetBeverage();
    }
}