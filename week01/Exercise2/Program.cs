using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        string grade = "";
        string sign = "";

        // Determine the letter grade
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        // Determine the sign (+ or -)
        int lastDigit = score % 10;

        if (grade != "A" && grade != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (grade == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {grade}{sign}");

         if (score >= 70)
        {
            Console.WriteLine("Hurray. You passed.");
        }

        else 
        {
            Console.WriteLine("Try harder next time.");
        }
    }
}
    
