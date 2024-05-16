//Created a log that displays all the activities that have been done
using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        int[] activities = [0,0,0];

        do
        {
            Console.WriteLine("Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Display what activities have been done");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the options: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                activities[0]++;
            }
            else if (userChoice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                activities[1]++;
            }
            else if (userChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                activities[2]++;   
            }
            else if (userChoice == "4")
            {
                Console.Clear();
                Console.WriteLine($"You have compleated the Breathing Activity {activities[0]} time/s.");
                Console.WriteLine($"You have completed the Reflecting Activity {activities[1]} time/s.");
                Console.WriteLine($"You have completed the Listing Activity {activities[2]} time/s.");
                Console.WriteLine("When you are ready to continue press enter");
                Console.ReadLine();
                Console.Clear();
            }
        } while (userChoice != "5");
    }
}