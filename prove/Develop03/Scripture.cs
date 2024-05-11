using Microsoft.VisualBasic;

public class Scripture
{
    private List<Word> _text = new List<Word>();
    private Reference _scriptureReference;

    // Constructors
    public Scripture(Reference scriptureReference, string text)
    {
        string[] textWords = text.Split(" ");
        foreach (string textWord in textWords)
        {
            Word word = new Word(textWord);
            _text.Add(word);
        }
        _scriptureReference = scriptureReference;
    }

    // methods
    public string GetDisplayText()
    {
        // Put display text together
        string text = $"{_scriptureReference.GetDisplayText()} ";
        foreach (Word textWord in _text)
        {
            text = $"{text} {textWord.GetDisplayText()}";
        }
        return text;
    }

    public void HideWords(int hideNumber)
    {
        Random wordPicker = new Random();

        for (int i = 0; i < hideNumber; i++)
        {
            if (wordPicker.Next(1, 2) == 1)
            {
                _text[i].ToggleShow();
            }
        }
    }

    public int getLength()
    {
        return _text.Count();
    }

}