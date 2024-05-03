using System;

class Program
{
    static void Main(string[] args)
    {
        Journal mainJournal = new Journal();
        Entry todaysEntry = new Entry();

        todaysEntry.Display();
    }
}