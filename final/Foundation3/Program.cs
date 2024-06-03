using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Fanta", "A thrilling lecture on the history of Fanta", "6/25/2024", "21:00", new Address("4554 W Utopia Rd.", "Yuma", "AZ", "USA"), "Owen", 5000);
        Reception reception = new Reception("Mandy Marriage", "Celebrate Mandy getting married with us", "6/5/2025", "09:30", new Address("250 E 7th st", "Phoenix", "AZ", "USA"), "mandy@gmail.com");
        Outdoor outdoor = new Outdoor("BBQ", "Fun BBQ with games and friends", "6/6/2024", "17:00", new Address("3044 W Zachary Dr", "Phoenix", "AZ", "USA"), "Sunny");

        List<Event> events = [lecture, reception, outdoor];

        foreach (Event funEvent in events)
        {
            Console.WriteLine("Standard Details");
            funEvent.StandardDetails();
            Console.WriteLine();
            Console.WriteLine("Full Details");
            funEvent.FullDetails();
            Console.WriteLine();
            Console.WriteLine("Short Description");
            funEvent.ShortDescription();
        }
    }
}