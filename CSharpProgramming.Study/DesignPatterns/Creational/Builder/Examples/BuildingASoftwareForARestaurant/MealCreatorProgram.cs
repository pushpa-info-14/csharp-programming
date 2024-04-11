namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.BuildingASoftwareForARestaurant
{
    public class MealCreatorProgram
    {
        public void Test()
        {
            MealCreator mealCreator = new MealCreator();
            MealBuilder veganMealBuilder = new VeganMealBuilder();

            mealCreator.PrepareMeal(veganMealBuilder);
            Meal veganMeal = veganMealBuilder.GetMeal();

            Console.WriteLine("Vegan Meal:");
            veganMeal.ShowMeal();
        }
    }
}
