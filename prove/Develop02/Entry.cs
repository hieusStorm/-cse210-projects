public class Entry
{
    public PromptGenerator _prompts = new PromptGenerator();
    public string _prompt;
    public string _response;
    public string _date;

    public void Display()
    {
        _prompt = _prompts.GetRandomPrompt();
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();

    }
}