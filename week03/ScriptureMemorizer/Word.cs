using Pastel; // Optional, for coloring text
using System;
using System.Drawing;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Default state: not hidden
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length).Pastel(System.Drawing.Color.SkyBlue) : _text; //change dashes to skyblue
    }
}
