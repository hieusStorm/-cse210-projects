public class ListingActivity : Activity
{
    //attributes
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This is activity will help you to focus on the good things in life by having you list as many items as you can in a certain area");
        _prompts.AddRange(["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?", "What are the fun things you like to do?", "What achievements have you had this year?", "What are some achievements that people close to you have had this year"]);
        _count = 0;
    }

    //methods
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may start in:  ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random promptPicker = new Random();
        return _prompts[promptPicker.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser() { 
        List<string> userAnswers = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        do
        {
            userAnswers.Add(Console.ReadLine());
        } while (DateTime.Now < endTime);

        return userAnswers;
    }
}