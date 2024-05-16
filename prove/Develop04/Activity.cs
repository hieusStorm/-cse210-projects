public class Activity
{
    //attributes
    private string _name;
    private string _description;
    private int _duration;

    //constructors

    //methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine("In seconds how long would you like to do this activity?");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(10);
    }
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well Done");
        ShowSpinner(5);
        Console.Clear();
        Console.WriteLine($"You have completed the {_name} Activity");
        ShowSpinner(10);
    }
    public void ShowSpinner(int seconds)
    {
        //dispaly a spinnner for 10 seconds
        List<string> spinnerStrings = ["\\", "|", "/", "-", "\\"];
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        do
        {
            Console.Write(spinnerStrings[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        } while (DateTime.Now < endTime);
    }
    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
        }
    }

    //setters
    protected void SetName(string name)
    {
        _name = name;
    }
    protected void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    //getters
    protected int GetDuration()
    {
        return _duration;
    }

}