using System.Drawing;

public abstract class Shape
{
    private string Color;

    public Shape(string color)
    {
        Color =  color;
    }

    public string GetColor()
    {
        return Color;
    }

     public void SetColor(string color)
    {
        Color = color;
    }

     public abstract double GetArea();





}