using System.Transactions;

public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();
    //methods
    public void Display() {}
    public int commentCount() {
        return comments.Count();
    }
}