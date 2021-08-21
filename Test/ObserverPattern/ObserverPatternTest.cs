using System;
using Core.ObserverPattern;
using NUnit.Framework;

namespace Test.ObserverPattern
{
    public class ObserverPatternTest
    {
        [Test]
        public void TestDynamicCollaboration()
        {
            Console.WriteLine("===");
            Console.WriteLine($"Observer Pattern!");
            Console.WriteLine("===");
            // Creating the metters 
            Meter meter1 = new("meter#1");
            Meter meter2 = new("meter#2");
            // Register the meter with the Subject base class of the Sensor.
            Sensor sensor = new(5);
            sensor.Register(meter1);
            sensor.Register(meter2);

            // Starting collaboration
            sensor.Check();
            Console.WriteLine("===");
            Assert.Pass();
        }
    }
}
