﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Factory.Examples.LoggingSystem
{
    public static class LoggerFactory
    {
        public static ILogger CreateLogger(string type)
        {
            switch (type.ToLower())
            {
                case "console":
                    return new ConsoleLogger();
                case "file":
                    return new FileLogger("log.txt");
                // For simplicity, file path is hardcoded
                // You can extend here with other logger types
                default:
                    throw new ArgumentException("Invalid logger type");
            }
        }
    }
}
