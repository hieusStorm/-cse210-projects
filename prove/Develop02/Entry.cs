public class Entry
{
    public string _prompt {get; set;} = "";
    public string _response {get; set;} = "";
    public string _date {get; set;} = DateTime.Now.ToString("MM/dd/yyyy");

    public void Display()
    {
        if (_prompt == "")
        {
            PromptGenerator prompts = new PromptGenerator(); 
            _prompt = prompts.GetRandomPrompt();
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