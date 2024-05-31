using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments.AddRange(comments);
    }
    //methods
    public void Display() { 
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments {CommentCount()}");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
    public int CommentCount()
    {
        return _comments.Count();
    }
}