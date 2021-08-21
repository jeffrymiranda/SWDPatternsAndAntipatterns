namespace Core.BuilderPattern
{
    public class MacBookAir : IBuilder
    {
        private readonly string model;
        private readonly Product product;
        public MacBookAir(string model)
        {
            product = new Product();
            this.model = model;
        }
        public void StartUpOperations()
        {   // Starting with brandname
            product.Add("-----------");
            product.Add($"MacBook model: {model}");
        }
        public void BuildBody()
        {
            product.Add("This is a body of a MacBook Air");
        }
        public void SetInches()
        {
            product.Add("13\" Inches");
        }

        public void AddStorage()
        {
            product.Add("256 GB");
        }
        public void EndOperations()
        {
            product.Add("-----------");
        }
        public Product GetMac()
        {
            return product;
        }
    }
}
