using System;
namespace Core.ObserverPattern
{
    public class Meter : IObserver
    {
        private readonly string observerName;
        public Meter(string observerName)
        {
            this.observerName = observerName;
        }

        public void Update(Sensor sensor)
        {
            Console.WriteLine($"{observerName} - Sensor Value: {sensor.GetValue()}");
        }
    }
}
