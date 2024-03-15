namespace CSharpProgramming.Study.BroCode
{
    public class Lesson25ParamsKeyword
    {
        public void Method1()
        {
            // params keyword - A method parameter that takes a variable number of arguments.
            //                  The parameter type must be a single-dimensional array


            Console.WriteLine(CheckOut(3.99, 5.75, 15, 1.50, 10.25));
        }

        public double CheckOut(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
