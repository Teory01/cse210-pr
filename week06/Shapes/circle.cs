/// <summary>
/// Represents a Circle class that inherits from the Shape class.
/// </summary>
public class Circle : Shape
{
    /// <summary>
    /// Private field to store the radius of the circle.
    /// </summary>
    private double _radius;

    /// <summary>
    /// Initializes a new instance of the Circle class with specified color and radius.
    /// </summary>
    /// <param name="color">The color of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    
    /// <summary>
    /// Calculates and returns the area of the circle.
    /// </summary>
    /// <returns>The area of the circle as a double value.</returns>
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}