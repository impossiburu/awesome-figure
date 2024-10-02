using NUnit.Framework;

[TestFixture]
public class ShapeFactoryTests
{
    [Test]
    public void CreateShape_Circle_ReturnsCirclInstanse()
    {
        ShapeFactory shapeFactory = new ShapeFactory();
        IShape circle = shapeFactory.CreateShape("circle", 3);

        Assert.IsTrue(circle is Circle);
    }

    [Test]
    public void CreateShape_Triangle_ReturnsTriangleInstanse()
    {
        ShapeFactory shapeFactory = new ShapeFactory();
        IShape triangle = shapeFactory.CreateShape("triangle", 3, 4);

        Assert.IsTrue(triangle is Triangle);
    }

    [Test]
    public void CreateShape_InvalidShapeType()
    {
        ShapeFactory shapeFactory = new ShapeFactory();
        Assert.Throws<NotSupportedException>(() => shapeFactory.CreateShape("squere", 4, 4));
    }
}
