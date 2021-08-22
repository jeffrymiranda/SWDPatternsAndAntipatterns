using System;
using Core.FactoryPattern;
using NUnit.Framework;

namespace Test.FactoryPattern
{
    public class FactoryPatternTest
    {
        [Test]
        public void FactoryPatternTest_HappyPath()
        {
            Console.WriteLine("===");
            Console.WriteLine($"Factory Method Pattern!");
            Console.WriteLine("===");

            // Concrete class creation
            IFirstPmtDateFactory firstPmtDayFactory = new ConcreteFactory();

            // Instance creation using polymorphism
            IFirstPmtDateStrategy fisrtPmtDateStrategy = firstPmtDayFactory.GetStrategy("dayAfter");
            fisrtPmtDateStrategy.CalculateFirstPmtDate();

            // Instance creation using polymorphism
            fisrtPmtDateStrategy = firstPmtDayFactory.GetStrategy("setDay");
            fisrtPmtDateStrategy.CalculateFirstPmtDate();
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
