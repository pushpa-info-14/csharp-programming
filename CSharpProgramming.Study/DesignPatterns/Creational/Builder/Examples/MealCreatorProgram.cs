namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples;

public class MealCreatorProgram
{
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

	public abstract class MealBuilder
	{
		protected Meal Meal = new();

		public abstract void SetDrink();

		public abstract void SetMainDish();

		public abstract void SetSide();

		public abstract void SetDessert();

		public Meal GetMeal() => Meal;
	}

	public class VeganMealBuilder : MealBuilder
	{
		public override void SetDrink()
		{
			Meal.Drink = "Water";
		}

		public override void SetMainDish()
		{
			Meal.MainDish = "Vegan Burger";
		}

		public override void SetSide()
		{
			Meal.Side = "Salad";
		}

		public override void SetDessert()
		{
			Meal.Dessert = "Fruit Bowl";
		}
	}

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

	public static void Test()
	{
		var mealCreator = new MealCreator();
		MealBuilder veganMealBuilder = new VeganMealBuilder();

		mealCreator.PrepareMeal(veganMealBuilder);
		var veganMeal = veganMealBuilder.GetMeal();

		Console.WriteLine("Vegan Meal:");
		veganMeal.ShowMeal();
	}
}
