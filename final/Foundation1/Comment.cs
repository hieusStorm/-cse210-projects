public class Comment
{
    private string _author;
    private string _text;

    //constructor

    public Comment(string author, string text) {
        _author = author;
        _text = text;
    }

    //method
    public void Display() {
        Console.WriteLine($"Comment Author: {_author}");
        Console.WriteLine($"Comment: {_text}");
    }
}