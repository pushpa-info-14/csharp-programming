﻿namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder
{
    public class BeverageBuilderProgram
    {
        public class Beverage
        {
            public int Water { get; set; }
            public int Milk { get; set; }
            public int Sugar { get; set; }
            public int PowderQuantity { get; set; }
            public string BeverageName { get; set; }

            public string ShowBeverage()
            {
                return "Hot " + BeverageName + " [" + Water + " ml of water, " + Milk + "ml of milk, " + Sugar
                       + " gm of sugar, " + PowderQuantity + " gm of " + BeverageName + "]\n";
            }
        }

        public abstract class BeverageBuilder
        {
            protected Beverage Beverage;

            public void CreateBeverage()
            {
                Beverage = new Beverage();
            }
            public Beverage GetBeverage()
            {
                return Beverage;
            }

            public abstract void SetBeverageType();
            public abstract void SetWater();
            public abstract void SetMilk();
            public abstract void SetSugar();
            public abstract void SetPowderQuantity();
        }

        public class CoffeeBuilder : BeverageBuilder
        {
            public override void SetWater()
            {
                Console.WriteLine("Step 1 : Boiling water");
                GetBeverage().Water = 40;
            }

            public override void SetMilk()
            {
                Console.WriteLine("Step 2 : Adding milk");
                GetBeverage().Milk = 50;
            }

            public override void SetSugar()
            {
                Console.WriteLine("Step 3 : Adding Sugar");
                GetBeverage().Sugar = 10;
            }

            public override void SetPowderQuantity()
            {
                Console.WriteLine("Step 4 : Adding 15 Grams of coffee powder");
                GetBeverage().PowderQuantity = 15;
            }

            public override void SetBeverageType()
            {
                Console.WriteLine("Coffee");
                GetBeverage().BeverageName = "Coffee";
            }
        }

        public class TeaBuilder : BeverageBuilder
        {
            public override void SetWater()
            {
                Console.WriteLine("Step 1 : Boiling water");
                GetBeverage().Water = 50;
            }

            public override void SetMilk()
            {
                Console.WriteLine("Step 2 : Adding milk");
                GetBeverage().Milk = 60;
            }

            public override void SetSugar()
            {
                Console.WriteLine("Step 3 : Adding Sugar");
                GetBeverage().Sugar = 15;
            }

            public override void SetPowderQuantity()
            {
                Console.WriteLine("Step 4 : Adding 20 Grams of coffee powder");
                GetBeverage().PowderQuantity = 20;
            }

            public override void SetBeverageType()
            {
                Console.WriteLine("Tea");
                GetBeverage().BeverageName = "Tea";
            }
        }

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

        public void Test()
        {
            var beverageDirector = new BeverageDirector();

            var tea = new TeaBuilder();
            var beverage = beverageDirector.MakeBeverage(tea);
            Console.WriteLine(beverage.ShowBeverage());

            var coffee = new CoffeeBuilder();
            beverage = beverageDirector.MakeBeverage(coffee);
            Console.WriteLine(beverage.ShowBeverage());
        }
    }
}
