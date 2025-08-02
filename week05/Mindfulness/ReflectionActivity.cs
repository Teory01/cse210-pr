using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "What made this time different than other times?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times when you have shown strength and resilience. This will help you recognize your power and how to use it in other aspects of life.");
    }

    public override void RunActivity()
    {
        Random rand = new Random();
        Console.WriteLine($"\n{_prompts[rand.Next(_prompts.Length)]}\n");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Length)];
            Console.WriteLine($"> {question}");
            ShowSpinner(4);
            Console.WriteLine();
        }
    }
}
