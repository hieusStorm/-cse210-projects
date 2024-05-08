using Microsoft.VisualBasic;

public class Scripture
{
    private List<Word> _text = new List<Word>();
    private Reference _scriptureReference;

    // Constructors
    public Scripture(Reference scriptureReference, string text)
    {
        Word textWord = new Word("text");
        _text.Add(textWord);
        _scriptureReference = scriptureReference;
    }

    // methods
    public string GetDisplayText()
    {
        // Put display text together
        return "True";
    }

    public void HideWords(int hideNumber)
    {
        //Hide a certain number of words
    }

}