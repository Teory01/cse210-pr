using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create video 1
        Video video1 = new Video("Mastering LINQ in C#", "Dev Insights", 540);
        video1.AddComment(new Comment("Alice", "Very helpful explanation!"));
        video1.AddComment(new Comment("Bob", "Loved the visuals."));
        video1.AddComment(new Comment("Charlie", "Can you do one on async/await?"));

        // Create video 2
        Video video2 = new Video("React vs Angular: 2025", "CodeCompare", 780);
        video2.AddComment(new Comment("David", "Angular all the way!"));
        video2.AddComment(new Comment("Emma", "React is so much easier."));
        video2.AddComment(new Comment("Frank", "Thanks for the comparison."));

        // Create video 3
        Video video3 = new Video("10 CSS Tips You Didn't Know", "WebStyler", 420);
        video3.AddComment(new Comment("Grace", "Wow, tip #7 blew my mind."));
        video3.AddComment(new Comment("Henry", "This saved my project."));
        video3.AddComment(new Comment("Ivy", "Please do more CSS tricks."));

        // Create video 4
        Video video4 = new Video("How GPT Works", "AI Explained", 600);
        video4.AddComment(new Comment("Jack", "AI is fascinating!"));
        video4.AddComment(new Comment("Karen", "Very informative."));
        video4.AddComment(new Comment("Leo", "Can’t wait for the next video."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display video info and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
