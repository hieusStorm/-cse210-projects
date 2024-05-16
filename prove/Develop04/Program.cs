using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice;

        do
        {
            Console.WriteLine("Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the options: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userChoice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();   
            }
        } while (userChoice != 4);
    }
}