using System;
namespace Core.FactoryPattern
{
    public class ConcreteFactory : IFirstPmtDateFactory
    {
        public IFirstPmtDateStrategy GetStrategy(string datingType)
        {
            return datingType switch
            {
                "dayAfter" => new DayAfter(),
                "setDay" => new SetDay(),
                _ => throw new NotImplementedException("Not valid strategy"),
            };
        }
    }
}
