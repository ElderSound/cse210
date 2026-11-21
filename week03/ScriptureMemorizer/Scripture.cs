
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    // Constructor: receives the reference and scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // Hide a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);

            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    // Return the reference and scripture text
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", displayWords);

        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }

    // Check whether all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
