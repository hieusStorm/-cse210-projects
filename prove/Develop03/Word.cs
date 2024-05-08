public class Word
{
    private string _text;
    private bool _show = true;

    // Constructor
    public Word(string text)
    {
        _text = text;
    }

    // Methods
    public bool isShown() {
        return _show;
    }

    public void ToggleShow()
    {
        if (_show == true)
        {
            _show = false;
        }
        else
        {
            _show = true;
        }
    }

    public string GetDisplayText() {
        return _text;
    }
}