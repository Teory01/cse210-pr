using System;

/// <summary>
/// Abstract base class representing a shape in a graphical system.
/// This class defines common properties and methods that all shapes should implement.
/// </summary>
public abstract class Shape
{
    // Private field to store the color of the shape
    private string _color;

    /// <summary>
    /// Initializes a new instance of the Shape class with the specified color.
    /// </summary>
    /// <param name="color">The color of the shape.</param>
    public Shape(string color)
    {
        _color = color;
    }

    /// <summary>
    /// Gets the color of the shape.
    /// </summary>
    /// <returns>The color of the shape as a string.</returns>
    public string GetColor()
    {
        return _color;
    }

    /// <summary>
    /// Sets the color of the shape to the specified value.
    /// </summary>
    /// <param name="color">The new color for the shape.</param>
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}