public class ReflectingActivity : Activity
{
    //attributes
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other ascpects of your life.");

        _prompts.AddRange(["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Think of a time when you stood up for yourself."]);

        _questions.AddRange(["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"]);
    }

    //methods
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the prompt below");
        DisplayPrompt();
        Console.WriteLine("Press enter when you are ready");
        Console.ReadLine();
        Console.WriteLine("Now consider the following questions in relation to this experience");
        Console.Write("Begin in  ");
        ShowCountDown(5);
        Console.WriteLine();
        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random promptPicker = new Random();
        return _prompts[promptPicker.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random questionPicker = new Random();
        return _questions[questionPicker.Next(_questions.Count)];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }
    public void DisplayQuestions() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        do
        {
            string question = GetRandomQuestion();
            Console.Write($"{question} ");
            ShowSpinner(10);
            Console.WriteLine();
        } while (DateTime.Now < endTime);
     }
}