namespace CSharpProgramming.Study.DesignPatterns.O2_Structural.O6_Flyweight;

public class ForestSimulationProgram
{
	// The Flyweight class
	class TreeType
	{
		public string Name { get; }
		public string Color { get; }
		public string Texture { get; }
		public TreeType(string name, string color, string texture)
		{
			Name = name;
			Color = color;
			Texture = texture;
		}
		public void Draw(int x, int y)
		{
			Console.WriteLine($"Drawn a {Name} tree with {Color} color and {Texture} texture at ({x}, {y})");
		}
	}

	// The Flyweight Factory
	class TreeFactory
	{
		private static readonly Dictionary<string, TreeType> TreeTypes = new();
		public static TreeType GetTreeType(string name, string color, string texture)
		{
			var key = $"{name}_{color}_{texture}";
			if (!TreeTypes.ContainsKey(key))
			{
				var type = new TreeType(name, color, texture);
				TreeTypes.Add(key, type);
			}
			return TreeTypes[key];
		}
	}

	// The context class that uses the Flyweight
	class Tree
	{
		private readonly TreeType _treeType;
		private readonly int _x;
		private readonly int _y;

		public Tree(int x, int y, TreeType treeType)
		{
			_x = x;
			_y = y;
			_treeType = treeType;
		}

		public void Draw()
		{
			_treeType.Draw(_x, _y);
		}
	}

	public void Test()
	{
		var forest = new List<Tree>();

		// Adding trees to forest
		forest.Add(new Tree(1, 2, TreeFactory.GetTreeType("Pine", "Green", "PineTexture")));
		forest.Add(new Tree(10, 20, TreeFactory.GetTreeType("Pine", "Green", "PineTexture")));
		forest.Add(new Tree(5, 7, TreeFactory.GetTreeType("Oak", "Brown", "OakTexture")));

		foreach (var tree in forest)
		{
			tree.Draw();
		}
	}
}
