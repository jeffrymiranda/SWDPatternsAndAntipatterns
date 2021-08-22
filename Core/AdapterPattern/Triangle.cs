using System;
namespace Core.AdapterPattern
{
    public class Triangle : ITriangle
    {
        private readonly double baseLength; // base
        private readonly double height; // height
        public Triangle(double length, double height)
        {
            baseLength = length;
            this.height = height;
        }
        public double CalculateAreaOfTriangle()
        {
            return 0.5 * baseLength * height;
        }
        public void AboutTriangle()
        {
            Console.WriteLine("Actually, I am a Triangle.");
        }
    }
}
