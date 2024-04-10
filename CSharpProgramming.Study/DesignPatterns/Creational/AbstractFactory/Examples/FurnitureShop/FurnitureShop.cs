﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.AbstractFactory.Examples.FurnitureShop;

public class FurnitureShop
{
    private readonly IChair _chair;
    private readonly ISofa _sofa;

    public FurnitureShop(IFurnitureFactory factory)
    {
        _chair = factory.CreateChair();
        _sofa = factory.CreateSofa();
    }

    public void ShowProducts()
    {
        _chair.SitOn();
        _sofa.LayOn();
    }
}