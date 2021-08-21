namespace Core.BuilderPattern
{
    public class Director
    {
        private IBuilder builder;
        /*
         * A series of steps.In real life, these steps
         * can be much more complex.
         */
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.SetInches();
            builder.AddStorage();
            builder.EndOperations();
        }
    }
}
