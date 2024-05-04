using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice;
        Journal mainJournal = new Journal();
        // List<Entry> todaysEntries = new List<Entry>();
        Console.WriteLine("Welcome to the Journal program!");

        do
        {
            Console.WriteLine("What would you like to do? (Please enter a number with the corresponding option)");
            Console.WriteLine("1: Write");
            Console.WriteLine("2: Display");
            Console.WriteLine("3: Save");
            Console.WriteLine("4: Load");
            Console.WriteLine("5: Quit");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                Entry newEntry = new Entry();
                newEntry.Display();
                mainJournal.AddEntry(newEntry);
            }
            else if (menuChoice == "2")
            {
                mainJournal.DisplayAll();
            }
            else if (menuChoice == "3")
            {
                Console.WriteLine("What is the file name?");
                string name = Console.ReadLine();

                mainJournal.SaveToFile(name);
            }
            else if (menuChoice == "4") {
                Console.WriteLine("What is the file name?");
                string name = Console.ReadLine();

                mainJournal.LoadFromFile(name);
            }
        } while (menuChoice != "5");
    }
}