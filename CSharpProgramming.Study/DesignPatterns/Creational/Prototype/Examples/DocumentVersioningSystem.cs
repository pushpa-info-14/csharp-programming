namespace CSharpProgramming.Study.DesignPatterns.Creational.Prototype.Examples
{
    public class DocumentVersioningSystem
    {
        // Prototype - DocumentPrototype Interface
        private interface IDocumentPrototype
        {
            IDocumentPrototype Clone();
        }

        // Concrete Prototype - Document Class
        private class Document : IDocumentPrototype
        {
            public string Title { get; set; }
            public string Content { get; set; }

            public IDocumentPrototype Clone()
            {
                return new Document
                {
                    Title = this.Title,
                    Content = this.Content
                };
            }

            public void Display()
            {
                Console.WriteLine($"Title: {Title}\nContent: {Content}\n");
            }
        }

        // Client Code
        public void Test()
        {
            var originalDoc = new Document
            {
                Title = "Prototype Design Pattern",
                Content = "This is a document explaining the prototype design pattern."
            };

            Console.WriteLine("Original Document:");
            originalDoc.Display();

            // The user now edits the document.
            var versionedDoc = (Document)originalDoc.Clone();
            versionedDoc.Content += "\nNow, the content has been updated to include more details.";

            Console.WriteLine("Versioned Document:");
            versionedDoc.Display();

            // The original document remains unchanged, but we have a new version saved.
            // In reality, we might just save the delta (changes) for efficiency.
        }
    }
}
