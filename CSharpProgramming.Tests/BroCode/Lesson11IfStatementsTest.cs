﻿using CSharpProgramming.Study.BroCode;

namespace CSharpProgramming.Tests.BroCode
{
    public class Lesson11IfStatementsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var lesson = new Lesson11IfStatements();

            using var sr = new StringReader("30");
            Console.SetIn(sr);
            lesson.Method1();
        }
    }
}
