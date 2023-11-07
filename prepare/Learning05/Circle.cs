public class Circle : Shape
{
    private double Radius;

    public Circle(string color, double radius) : base (color)
    {
        Radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}