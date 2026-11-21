
public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor: initialize the word as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word again
    public void Show()
    {
        _isHidden = false;
    }

    // Check whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Return the word or underscores while preserving punctuation
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        char[] characters = _text.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetter(characters[i]))
            {
                characters[i] = '_';
            }
        }

        return new string(characters);
    }
}
