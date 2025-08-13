using System;

/// <summary>
/// Program.cs — Simple version that exceeds core requirements:
/// 1. Tracks the number of goals completed during the current session.
/// 2. Remembers and displays the last completed goal.
/// 3. Shows a session summary upon exiting.
/// </summary>
class Program
{
    private static int _completedThisSession = 0;
    private static string _lastCompletedGoal = "";

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Subscribe to the goal completion event
        goalManager.OnGoalCompleted += OnGoalCompleted;

        // Start the main loop
        goalManager.Start();

        // Show a session summary after quitting
        Console.WriteLine("\n--- Session Summary ---");
        Console.WriteLine($"Goals completed this session: {_completedThisSession}");
        if (!string.IsNullOrEmpty(_lastCompletedGoal))
        {
            Console.WriteLine($"Last goal completed: {_lastCompletedGoal}");
        }
        else
        {
            Console.WriteLine("No goals were completed this session.");
        }
    }

    // Event handler for completed goals
    private static void OnGoalCompleted(string goalName)
    {
        _completedThisSession++;
        _lastCompletedGoal = goalName;
    }
}
