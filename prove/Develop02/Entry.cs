public class Entry
{
    public PromptGenerator _prompts = new PromptGenerator();
    public string _prompt = "";
    public string _response = "";
    public string _date = DateTime.Now.ToString("MM/dd/yyyy");

    public void Display()
    {
        if (_prompt == "")
        {
            _prompt = _prompts.GetRandomPrompt();
        }

        Console.WriteLine(_date);
        Console.WriteLine(_prompt);

        if (_response != "")
        {
            Console.WriteLine(_response);
        }
        else
        {
            _response = Console.ReadLine();
        }
    }
}