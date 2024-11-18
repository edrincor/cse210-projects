using System;

public class Fraction
{
    //Private attributes
    private int _topFraction;
    private int _bottomFraction;

    //Constructors
    public Fraction()
    {
        _topFraction = 1;
        _bottomFraction = 1;
    }
    public Fraction(int wholeNumber)
    {
        _topFraction = wholeNumber;
        _bottomFraction = 1;
    }
    public Fraction(int topFraction, int bottomFraction)
    {
        _topFraction = topFraction;
        _bottomFraction = bottomFraction;
    }

    // Getters and Setters
    public int TopFraction
    {
        get { return _topFraction; }
        set { _topFraction = value; }
    }
    public int BottomFraction
    {
        get { return _bottomFraction; }
        set { _bottomFraction = value; }
    }

    //Return methods
    public string GetFractionString()
    {
        return _topFraction + "/" + _bottomFraction;
    }
    public double GetDecimalValue()
    {
        return (double)_topFraction/(double)_bottomFraction;
    }
}