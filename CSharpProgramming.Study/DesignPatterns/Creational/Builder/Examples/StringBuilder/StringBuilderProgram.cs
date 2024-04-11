namespace CSharpProgramming.Study.DesignPatterns.Creational.Builder.Examples.StringBuilder
{
    public class StringBuilderProgram
    {
        public void Test()
        {
            var constructor = new StringConstructor();

            constructor.AppendLine("Hello, Builder pattern!")
                .AppendWords("This", "is", "a", "custom", "string", "builder!")
                .AppendLine("It's efficient.");

            var customStr = constructor.Build();

            Console.WriteLine(customStr);
        }
    }
}
