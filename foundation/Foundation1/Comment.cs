using System;

public class Comment
{
    private string _commentAuthor;
    private string _commentText;

    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _commentText = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commentAuthor}:");
        Console.WriteLine(_commentText);
    }
}