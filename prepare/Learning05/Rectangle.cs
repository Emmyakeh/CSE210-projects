public class Rectangle : Shape
{
    private double Length;
    private double Width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Length * Width;
    }

}