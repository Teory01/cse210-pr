using System;

/// <summary>
/// Represents a Rectangle class that inherits from the Shape class.
/// </summary>
public class Rectangle : Shape
{
    // Private fields to store the dimensions of the rectangle
    private int _length;
    private int _width;

    public Rectangle(string color, int length, int width) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}