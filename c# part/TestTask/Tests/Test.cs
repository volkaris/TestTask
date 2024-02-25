using System.Diagnostics;
using TestTask.Figures;
using Xunit;

namespace TestTask.Tests;

public class Test
{
    [Fact]
    public void CircleTest()
    {
        IShape circle1 = new Circle(1);
        IShape circle2 = new Circle(2);
        IShape circle3 = new Circle(3);
        IShape circle4 = new Circle(4.5);


        Assert.Throws<ArgumentException>(() => new Circle(-10));
        Assert.Equal(3, (int)circle1.CalculateArea());
        Assert.Equal(12, (int)circle2.CalculateArea());
        Assert.Equal(28, (int)circle3.CalculateArea());
        Assert.Equal(63, (int)circle4.CalculateArea());
    }


    [Fact]
    public void TriangleTest()
    {
        var triangle1 = new Triangle(5,3,7);
        var triangle2 = new Triangle(8, 6, 9);
        

        Assert.Throws<ArgumentException>(() => new Triangle(10, 3, 3));


        Assert.Equal(6, (int)triangle1.CalculateArea());
        Assert.False(triangle1.IsRectangular());

        Assert.Equal(23, (int)triangle2.CalculateArea());
        Assert.False(triangle2.IsRectangular());

        
    }
    
    
    
    [Fact]
    public void RectangularTriangleTest()
    {
        var triangle1 = new Triangle(8,15,17);
        var triangle2 = new Triangle(3, 4, 5);
        var triangle3 = new Triangle(5, 12, 13);

        Assert.Throws<InvalidDataException>(() => new Triangle(10, 3, 3));


        Assert.Equal(60, triangle1.CalculateArea());
        Assert.True(triangle1.IsRectangular());

        Assert.Equal(6, triangle2.CalculateArea());
        Assert.True(triangle2.IsRectangular());

        Assert.Equal(30, triangle3.CalculateArea());
        Assert.True(triangle3.IsRectangular());
    }
}