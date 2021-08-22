using System;
namespace Core.FactoryPattern
{
    public class DayAfter : IFirstPmtDateStrategy
    {
        public void CalculateFirstPmtDate()
        {
            Console.WriteLine($"The first payment will be 30 days after the formalization of the credit.");
        }
    }
}
