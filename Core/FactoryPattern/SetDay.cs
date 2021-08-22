using System;
namespace Core.FactoryPattern
{
    public class SetDay : IFirstPmtDateStrategy
    {
        public void CalculateFirstPmtDate()
        {
            Console.WriteLine($"The first payment will the next 15th after the formalization of the credit.");
        }
    }
}
