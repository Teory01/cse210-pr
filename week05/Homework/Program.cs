using System;

class Program
{
    static void Main(string[] args)
    {
        // Base Assignment Test
        Assignment assignment1 = new Assignment("Uche Kelechi", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        // MathAssignment Test
        MathAssignment math = new MathAssignment("Jeneva Smith", "Fractions", "Section 5.3", "7-14");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        // WritingAssignment Test
        WritingAssignment writing = new WritingAssignment("Emma Okon", "European History", "The Causes of Cold World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
