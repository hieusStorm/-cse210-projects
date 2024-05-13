public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "General Studies";
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}