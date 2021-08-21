namespace Core.BuilderPattern
{
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void SetInches();
        void AddStorage();
        void EndOperations();
        Product GetMac();
    }
}
