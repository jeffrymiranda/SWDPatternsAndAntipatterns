using System;
namespace Core.AdapterPattern
{
    public class Rectangle : IRectangle
    {
        private readonly double length;
        private readonly double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public void AboutMe()
        {
            Console.WriteLine("Actually, I am a Rectangle");
        }
    }
}
