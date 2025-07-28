using System.Collections.Generic;

public class Video
{
    // Declare a public string property for the title of the video
    public string Title { get; set; }
    // Declare a public string property for the author of the video
    public string Author { get; set; }
    public int Length { get; set; } // in seconds

    private List<Comment> _comments = new List<Comment>();

    // Constructor for the Video class
    public Video(string title, string author, int length)
    {
        // Set the title of the video
        Title = title;
        // Set the author of the video
        Author = author;
        // Set the length of the video
        Length = length;
    }

    //This method adds a comment to the list of comments
    public void AddComment(Comment comment)
    {
        //Add the comment to the list of comments
        _comments.Add(comment);
    }

    // This method returns the number of comments
    public int GetNumberOfComments()
    {
        // Return the count of the _comments list
        return _comments.Count;
    }

    // This method returns the list of comments
    public List<Comment> GetComments()
    {
        // Return the list of comments
        return _comments;
    }
}
