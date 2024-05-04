public class Journal
{
    List<Entry> _journalEntries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Add a new Entry to the Journal
        _journalEntries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry journalEntry in _journalEntries)
        {
            journalEntry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter savedJournal = new StreamWriter(fileName))
        {
            foreach (Entry journalEntry in _journalEntries)
            {
                savedJournal.WriteLine(journalEntry._date);
                savedJournal.WriteLine(journalEntry._prompt);
                savedJournal.WriteLine(journalEntry._response);
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        Console.WriteLine(fileName);
    }
}