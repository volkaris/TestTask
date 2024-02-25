namespace TestTask.Figures;

public class Triangle : IShape
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (!IsValidTriangle(firstSide, secondSide, thirdSide))
            throw new ArgumentException("Sides are violating triangle inequality");

        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    public double CalculateArea()
    {
        var halfOfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return double.Sqrt(halfOfPerimeter * (halfOfPerimeter - _firstSide) * (halfOfPerimeter - _secondSide) *
                           (halfOfPerimeter - _thirdSide));
    }

    public bool IsRectangular()
    {
        if (_firstSide > _secondSide && _firstSide > _thirdSide)
            return Math.Pow(_firstSide, 2) == Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2);
        else if (_secondSide > _firstSide && _secondSide > _thirdSide)
            return Math.Pow(_secondSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2);
        else if (_thirdSide > _firstSide && _thirdSide > _secondSide)
            return Math.Pow(_thirdSide, 2) == Math.Pow(_secondSide, 2) + Math.Pow(_firstSide, 2);
        return false;
    }

    private bool IsValidTriangle(double firstSide, double secondSide, double thirdSide)
    {
        return !(firstSide >= secondSide + thirdSide) && !(secondSide >= firstSide + thirdSide) &&
               !(thirdSide >= secondSide + firstSide);
    }
}