namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingASoftwareForARestaurant;

public class MealCreator
{
    public void PrepareMeal(MealBuilder builder)
    {
        builder.SetDrink();
        builder.SetMainDish();
        builder.SetSide();
        builder.SetDessert();
    }
}