using System;
using NUnit.Framework;
using Core.BuilderPattern;

namespace Test.BuilderPattern
{
    public class BuilderPatternTest
    {
        [Test]
        public void BuilderPatternTest_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine($"Builder Pattern!");
            Console.WriteLine("===");

            Director director = new Director();

            IBuilder b1 = new MacBookPro("MVVJ2LL/A");
            IBuilder b2 = new MacBookAir("MGND3LA/A");

            // Making MacBookPro
            director.Construct(b1);
            Product p1 = b1.GetMac();
            p1.Show();

            // Making MacBookAir
            director.Construct(b2);
            Product p2 = b2.GetMac();
            p2.Show();

            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
