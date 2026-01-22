using CSharpProgramming.Tests.Base;
using Xunit;
using Xunit.Abstractions;

namespace CSharpProgramming.Tests.InterviewQuestions;

public class Q5NoteService(ITestOutputHelper output) : BaseTest(output)
{
	public interface INote
	{
		string Title { get; set; }

		string Note { get; set; }
	}

	public interface INoteService
	{
		bool Insert(INote note);

		List<INote> GetNotesByTitle(string title);
	}

	public class NoteService : INoteService
	{
		private readonly Dictionary<string, Dictionary<string, List<INote>>> _folders;

		public NoteService()
		{
			_folders = new Dictionary<string, Dictionary<string, List<INote>>>();
		}

		public List<INote> GetNotesByTitle(string title)
		{
			var t = _folders.Values
				.Where(i => i.ContainsKey(title))

				.Select(i => i.Values).ToList();

			return new List<INote>();
		}

		public bool Insert(INote note)
		{
			throw new NotImplementedException();
		}
	}

	[Fact]
	public void Test()
	{

	}
}
