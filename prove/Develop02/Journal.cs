using System.Text.Json;

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
        using (StreamWriter savedJournal = new StreamWriter($"{fileName}.json"))
        {
            foreach (Entry journalEntry in _journalEntries)
            {
                string jsonEntry = JsonSerializer.Serialize(journalEntry);
                savedJournal.WriteLine(jsonEntry);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _journalEntries.Clear();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.json");
        foreach (string line in lines)
        {
            Entry journalEntry = JsonSerializer.Deserialize<Entry>(line);
            AddEntry(journalEntry);
        }
    }
}