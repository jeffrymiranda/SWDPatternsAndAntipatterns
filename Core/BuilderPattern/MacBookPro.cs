namespace Core.BuilderPattern
{
    public class MacBookPro : IBuilder
    {
        private readonly string model;
        private readonly Product product;
        public MacBookPro(string model)
        {
            product = new Product();
            this.model = model;
        }
        public void StartUpOperations()
        {   // Starting with brandname
            product.Add("-----------");
            product.Add($"MacBookPro model: {model}");
        }
        public void BuildBody()
        {
            product.Add("This is a body of a MacBook Pro");
        }
        public void SetInches()
        {
            product.Add("16\" Inches");
        }

        public void AddStorage()
        {
            product.Add("512 GB");
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
