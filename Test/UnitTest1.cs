using System;
using System.IO;
using NUnit.Framework;

namespace Test
{
    public class Tests
    {
        private const string Expected = "Software Design Patterns And Antipatterns!";

        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestMain()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Core.Program.Main();

            var result = sw.ToString().Trim();
            Assert.AreEqual(Expected, result);
        }
    }
}
