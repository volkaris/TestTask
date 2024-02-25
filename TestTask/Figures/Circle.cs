namespace TestTask.Figures;

public class Circle : IShape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius can't be less or equal than zero");
        }
        
        _radius = radius;
    }


    public double CalculateArea()
    {
        return double.Pi * double.Pow(_radius,2);
    }
}