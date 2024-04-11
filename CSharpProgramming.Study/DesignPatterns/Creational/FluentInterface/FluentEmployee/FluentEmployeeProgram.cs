namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.FluentEmployee
{
    public class FluentEmployeeProgram
    {
        public void Test()
        {
            //Create an Instance of Wrapper class i.e. FluentEmployee
            FluentEmployee obj = new();

            //Call Methods one by one using dot Operator whose Return Type is FluentEmployee
            obj.NameOfTheEmployee("Pushpa Kumara")
                .Born("10/10/1992")
                .WorkingOn("IT")
                .StaysAt("Sri Lanka");

            //To See the Details call the ShowDetails Method
            obj.ShowDetails();
        }
    }
}