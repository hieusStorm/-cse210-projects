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
                savedJournal.WriteLine($"{journalEntry._date}|{journalEntry._prompt}|{journalEntry._response}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            Entry journalEntry = new Entry();
            string[] parts = line.Split("|");

            journalEntry._date = parts[0];
            journalEntry._prompt = parts[1];
            journalEntry._response = parts[2];

            AddEntry(journalEntry);
        }
    }
}