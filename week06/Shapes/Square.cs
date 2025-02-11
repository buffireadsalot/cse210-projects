public class Square : Shape
{
    private double _length;

    public Square(string color, double length) : base(color)
    {
        _length = length;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _length * _length;
    }
}