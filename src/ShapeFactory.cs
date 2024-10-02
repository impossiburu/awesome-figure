using System;

namespace ConsoleApp_RAD
{
  public class ShapeFactory
  {
      public IShape CreateShape(string shapeType, params double[] parameters)
      {
          switch (shapeType.ToLower())
          {
              case "circle":
                  return new Circle(parameters[0]);
              case "triangle":
                  return new Triangle(parameters[0], parameters[1]);
              default:
                  throw new NotSupportedException($"Invalid shape type: {shapeType}");
          }
      }
  }
}