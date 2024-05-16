public class BreathingActivity : Activity
{
    //consturctor
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you clear your mind and focus by walking you through breathing in and out slowly.");
    }
    //methods
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        bool breath = true;

        do
        {
            Console.Clear();
            if (breath)
            {
                Console.Write("Breath in... ");
                breath = false;
            }
            else
            {
                Console.Write("Breath Out... ");
                breath = true;
            }
            ShowCountDown(5);
            Console.Clear();
        } while (DateTime.Now < futureTime);

        DisplayEndingMessage();
    }
}