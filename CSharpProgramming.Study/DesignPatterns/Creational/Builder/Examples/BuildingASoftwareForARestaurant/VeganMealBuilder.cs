namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingASoftwareForARestaurant;

public class VeganMealBuilder : MealBuilder
{
    public override void SetDrink()
    {
        meal.Drink = "Water";
    }

    public override void SetMainDish()
    {
        meal.MainDish = "Vegan Burger";
    }

    public override void SetSide()
    {
        meal.Side = "Salad";
    }

    public override void SetDessert()
    {
        meal.Dessert = "Fruit Bowl";
    }
}