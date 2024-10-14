using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Video
{
    private string  _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
 
    public Video(string author, string title, string length)
    {
        _title = title;
        _author = author;           
        string[] videoLength = length.Split(':');
        int minutes = int.Parse(videoLength[0]);
        int seconds =  int.Parse(videoLength[1]);
        _length = (60 * minutes) + seconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Video video, string author, string text)
    {
        Comment comment = new Comment(author, text);
        video._comments.Add(comment);
    }

    public int NumberOfComments()
    {
        int number = _comments.Count();
        return number;
    }

    public void DisplayAllComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void DisplayVideoDetails(Video video)
    {
        int comments = video.NumberOfComments();
        Console.WriteLine($"{_author}: '{_title}.' Length: {_length} Comments: {comments}");
    }
}
         