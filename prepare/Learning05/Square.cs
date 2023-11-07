public class Square : Shape
{
  private double Side;

  public Square(string color, double side) : base (color)
  {
    Side = side;
  }

    public override double GetArea()
    {
        return Side * Side;
    }

}