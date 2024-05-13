using System.ComponentModel.DataAnnotations;
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
        List<Word> shownText = new List<Word>();
        Random wordPicker = new Random();
        int maxWordIndex;

        foreach (Word textWord in _text)
        {
            if (textWord.isShown())
            {
                shownText.Add(textWord);
            }
        }

        maxWordIndex = shownText.Count;

        for (int i = 0; i < hideNumber; i++)
        {
            if (maxWordIndex > 0)
            {
                shownText[wordPicker.Next(0, maxWordIndex)].ToggleShow();
            }
        }
    }

    public int getLength()
    {
        return _text.Count();
    }

    public int getHiddenLength()
    {
        List<Word> hiddenText = new List<Word>();
        foreach (Word textWord in _text)
        {
            if (!textWord.isShown())
            {
                hiddenText.Add(textWord);
            }
        }

        return hiddenText.Count();
    }

}