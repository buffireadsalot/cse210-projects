using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        string wordsDisplay = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {wordsDisplay}";
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide && _words.Any(word => !word.IsHidden()))
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
