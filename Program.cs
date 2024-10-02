using AwesomeFigure;

namespace ConsoleApp_RAD
{
    class Programm
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape circle = shapeFactory.CreateShape("circle", 3);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            IShape triangle = shapeFactory.CreateShape("triangle", 4, 5);
            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");

            Console.ReadLine();
        }
    }
}

