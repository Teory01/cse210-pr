using System;
using System.Collections.Generic;

/**
 * This is the main program class that demonstrates the usage of different shape classes.
 * It creates instances of various shapes, displays their properties, and demonstrates
 * polymorphism by storing them in a list and iterating through them.
 */
class Program
{
    /**
     * The entry point of the program.
     * @param args Command line arguments (not used in this example)
     */
    static void Main(string[] args)
    {
        // Test individual shapes by creating instances and displaying their properties
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        Console.WriteLine("\n--- Shapes in a List ---");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        // Iterate and display
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
