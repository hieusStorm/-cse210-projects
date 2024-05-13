public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base("Unknown", "Writing Basics")
    {
        _title = "Intro to Me";
    } 

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) 
    {
        _title = title;
    }

    public string GetWritingInformation() {
        return _title;
    }
}