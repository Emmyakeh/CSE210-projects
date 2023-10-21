using System;

public class Fraction
{
    private int Top;
    private int Bottom;

    public Fraction()
    {
        Top = 1;
        Bottom = 1;
    }

    public Fraction(int topNumber)
    {
        Top = topNumber;
        Bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        Top = topNumber;
        Bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string text = $"{Top}/{Bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        
        return (double)Top/ (double)Bottom;
    }
}

    