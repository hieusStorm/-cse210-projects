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
        // Save to a current file
    }
    public void LoadFromFile(string fileName)
    {
        // Load from a file
    }
}