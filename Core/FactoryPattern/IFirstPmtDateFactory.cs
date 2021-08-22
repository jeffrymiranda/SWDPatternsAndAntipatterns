namespace Core.FactoryPattern
{
    public interface IFirstPmtDateFactory
    {
        IFirstPmtDateStrategy GetStrategy(string datingType);
    }
}
