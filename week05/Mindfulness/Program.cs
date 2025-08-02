using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App\n");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an option: ");

            string choice = Console.ReadLine();
            MindfulnessActivity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    continue;
            }

            activity.StartActivity();
            Console.WriteLine("\nPress Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}

/*
EXCEEDS REQUIREMENTS:
- Spinner animation is used with backspaces.
- Random prompts are drawn dynamically.
- Activities are in separate files with full abstraction and encapsulation.
- Fully meets inheritance, shared method, and attribute requirements.
- Clean structure to extend functionality in the future.
*/
// TODO: Implement the MindfulnessActivity class and its subclasses.