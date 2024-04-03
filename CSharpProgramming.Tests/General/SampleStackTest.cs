using CSharpProgramming.Study.General;

namespace CSharpProgramming.Tests.General
{
    public class SampleStackTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sampleStack = new SampleStack();
            sampleStack.Test();
        }
    }
}
