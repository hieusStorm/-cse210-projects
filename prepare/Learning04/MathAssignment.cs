public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment() : base("unknown", "General Maths")
    {
        _textBookSection = "1.0";
        _problems = "1-20";
    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}