namespace Core.AdapterPattern
{
    public class RectangleAdapter : IRectangle
    {
        private readonly ITriangle triangle;
        public RectangleAdapter(ITriangle triangle)
        {
            this.triangle = triangle;
        }

        public void AboutMe()
        {
            triangle.AboutTriangle();
        }

        public double CalculateArea()
        {
            return triangle.CalculateAreaOfTriangle();
        }
    }
}
