namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingASoftwareForARestaurant;

public abstract class MealBuilder
{
    protected Meal meal = new Meal();

    public abstract void SetDrink();
    public abstract void SetMainDish();
    public abstract void SetSide();
    public abstract void SetDessert();

    public Meal GetMeal() => meal;
}