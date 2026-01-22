namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O5_Composite;

public class FileSystemProgram
{

	// The Base Component Abstract class declares the common operations for both Leaf and Composite objects.
	public abstract class FileSystemItem
	{
		public string Name { get; }

		public FileSystemItem(string name)
		{
			Name = name;
		}

		// The following method is going to be overridden in both Leaf and Composite class
		public abstract decimal GetSizeInKB();
	}

	// This is going to be our Leaf class that represents the end objects. 
	// A leaf cannot have any children.
	// The Leaf object is the Object which does the actual work
	public class FileItem : FileSystemItem
	{
		// The following Property is going to hold the size of the file
		public long FileBytes { get; }

		// While creating the Leaf Object i.e. while Creating the FileItem Object,
		// we need to pass the File Name and the Size of the File
		// The File Name we need to pass the Base class constructor
		public FileItem(string name, long fileBytes) : base(name)
		{
			FileBytes = fileBytes;
		}

		// We need to override the following method to provide the actual implementation
		public override decimal GetSizeInKB()
		{
			// Divide the size which will be in bytes with the value of 1024 to convert into KB
			return decimal.Divide(FileBytes, 1024);
		}
	}

	// This is going to be our Composite class that represents the Composite objects. 
	// A Composite Object has children. 
	// The Children Can be a Leaf Object or Can be another Composite Object
	// The Composite objects delegate the actual work to their children and then combine the result.
	public class Directory : FileSystemItem
	{
		// The Following variable is going to hold all the child components of a composite components
		private readonly List<FileSystemItem> _children = new();

		// The Constructor takes the Composite name as the input parameter
		public Directory(string name) : base(name)
		{
		}

		// The following Method is used to add Child Components inside the Composite Component
		public void AddComponent(FileSystemItem NewNode)
		{
			_children.Add(NewNode);
		}

		// The following Method is used to Remove Child Components inside the Composite Component
		public void RemoveComponent(FileSystemItem RemoveNode)
		{
			_children.Remove(RemoveNode);
		}

		// Override the FileSystemItem class GetSizeinKB Method
		public override decimal GetSizeInKB()
		{
			// Summarizing the size of children
			return _children.Sum(x => x.GetSizeInKB());
		}
	}

	public void Test()
	{
		// The Client Code will work with all of the components(Both Leaf and Composite) via the base abstract class i.e.FileSystemItem.
		// FileSystemItem means the class that implements the FileSystemItem abstract class
		// Creating Leaf Objects i.e. Creating Files
		FileSystemItem myBook = new FileItem("MyBook.txt", 12000);
		FileSystemItem myVideo = new FileItem("MyVideo.mp4", 1000000);
		FileSystemItem myMusic = new FileItem("MyMusic.mp3", 20000);
		FileSystemItem myResume = new FileItem("MyResume.pdf", 18000);
		FileSystemItem mySoftware = new FileItem("MySoftware.exe", 250000);
		FileSystemItem myDocument = new FileItem("MyDocument.doc", 87000000);

		// Create the Root Directory i.e. Composite Object 
		var rootDirectory = new Directory("RootDirectory");

		// Add 2 More Folders i.e. two more composite objects  
		var folder1 = new Directory("Folder1");
		var folder2 = new Directory("Folder2");

		// Add the above two folders under Root Directory
		rootDirectory.AddComponent(folder1);
		rootDirectory.AddComponent(folder2);

		// Add files to Folder 1   
		folder1.AddComponent(myBook);
		folder1.AddComponent(myVideo);

		// Create a Sub Folder 1  
		var subFolder1 = new Directory("Sub Folder1");

		// Add files under Sub Folder1  
		subFolder1.AddComponent(myMusic);
		subFolder1.AddComponent(myResume);

		// Add Sub Folder 1 under Folder 1
		folder1.AddComponent(subFolder1);

		// Add files to folder 2  
		folder2.AddComponent(mySoftware);
		folder2.AddComponent(myDocument);

		Console.WriteLine("Composite Objects:");
		Console.WriteLine($"Total size of (RootDirectory): {rootDirectory.GetSizeInKB()} kB");
		Console.WriteLine($"Total size of (Folder 1): {folder1.GetSizeInKB()} kB");
		Console.WriteLine($"Total size of (Folder 2): {folder2.GetSizeInKB()} kB");
		Console.WriteLine($"Total size of (SubFolder 1): {subFolder1.GetSizeInKB()} kB");
		Console.WriteLine("\nLeaf Objects:");
		Console.WriteLine($"Total size of MyVideo File: {myVideo.GetSizeInKB()} kB");
		Console.WriteLine($"Total size of MyResume File: {myResume.GetSizeInKB()} kB");
		Console.WriteLine($"Total size of MyBook File: {myBook.GetSizeInKB()} kB");
		Console.WriteLine($"Total size of MyDocument File: {myDocument.GetSizeInKB()} kB");
	}
}
