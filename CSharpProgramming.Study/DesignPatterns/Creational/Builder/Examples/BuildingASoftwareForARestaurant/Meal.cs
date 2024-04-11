namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingASoftwareForARestaurant;

public class Meal
{
    public string Drink { get; set; }
    public string MainDish { get; set; }
    public string Side { get; set; }
    public string Dessert { get; set; }

    public void ShowMeal()
    {
        Console.WriteLine($"Drink: {Drink}");
        Console.WriteLine($"Main Dish: {MainDish}");
        Console.WriteLine($"Side: {Side}");
        Console.WriteLine($"Dessert: {Dessert}");
    }
}