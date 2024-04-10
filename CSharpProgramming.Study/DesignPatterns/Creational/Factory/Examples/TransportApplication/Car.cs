﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.TransportApplication
{
    public class Car : ITransport
    {
        public void StartRoute()
        {
            Console.WriteLine("Starting the journey with a car!");
            // Logic related to starting a car route
        }
    }
}