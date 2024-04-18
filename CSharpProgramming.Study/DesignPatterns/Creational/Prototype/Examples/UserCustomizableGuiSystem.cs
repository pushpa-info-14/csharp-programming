namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples
{
    public class UserCustomizableGuiSystem
    {
        // Prototype - IButtonPrototype Interface
        public interface IButtonPrototype
        {
            IButtonPrototype Clone();
        }

        // Concrete Prototype - StyledButton Class
        private class StyledButton : IButtonPrototype
        {
            public string Label { get; set; }
            public string Color { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public IButtonPrototype Clone()
            {
                return new StyledButton
                {
                    // Copy the style attributes
                    Color = Color,
                    Width = Width,
                    Height = Height,
                    // New label can be set by the user
                    Label = ""
                };
            }

            public void Display()
            {
                Console.WriteLine($"Button: {Label} | Color: {Color} | Size: {Width}x{Height}");
            }
        }

        // Client Code
        public void Test()
        {
            // User creates a styled button
            var originalButton = new StyledButton
            {
                Label = "Submit",
                Color = "Blue",
                Width = 100,
                Height = 50
            };

            Console.WriteLine("Original Button:");
            originalButton.Display();

            // User wants a new button with the same style but a different label
            var clonedButton = (StyledButton)originalButton.Clone();
            clonedButton.Label = "Cancel";

            Console.WriteLine("Cloned Button:");
            clonedButton.Display();
        }
    }
}
