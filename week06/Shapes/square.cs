using System;

/// <summary>
/// Represents a square shape, inheriting from the base Shape class.
/// </summary>
public class Square : Shape
{
    // Private field to store the length of a side of the square
    private int _side;

    /// <summary>
    /// Initializes a new instance of the Square class with specified color and side length.
    /// </summary>
    /// <param name="color">The color of the square.</param>
    /// <param name="side">The length of a side of the square.</param>
    public Square(string color, int side) : base (color)
    {
        _side = side;
    }

    /// <summary>
    /// Calculates and returns the area of the square.
    /// </summary>
    /// <returns>The area of the square as a double value.</returns>
    public override double GetArea()
    {
        return _side * _side;
    }
}