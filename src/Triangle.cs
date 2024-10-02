using System;

namespace ConsoleApp_RAD
{
	public class Triangle : IShape
    {
        public double Lenght { get; set; }
        public double Height { get; set; }
        
        public Triangle(double lenght, double height)
        {
            Lenght = lenght;
            Height = height;
        }
        
        public double CalculateArea()
        {
            return 0.5 * Lenght * Height;
        }
    }
}