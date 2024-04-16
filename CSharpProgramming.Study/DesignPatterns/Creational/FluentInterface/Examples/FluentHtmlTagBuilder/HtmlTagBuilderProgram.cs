namespace CSharpProgramming.Study.DesignPatterns.Creational.FluentInterface.Examples.FluentHtmlTagBuilder
{
    public class HtmlTagBuilderProgram
    {
        public void Test()
        {
            var tag = new HtmlTagBuilder("div")
                .AddAttribute("class", "container")
                .AddAttribute("id", "mainContainer")
                .WithContent("Hello, world!")
                .ToString();

            Console.WriteLine(tag);
            // Outputs: <div class='container' id='mainContainer'>Hello, world!</div>
        }
    }
}
