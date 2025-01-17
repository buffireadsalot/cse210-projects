using System;

//[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Entry
{

    public string _date();
    public string _promptText();
    public string _entryText();

    public void Display()
    {
        Console.WriteLine ($"{_promptText"});
        Console.WriteLine ($"{_date} | {_entryText}");
    }

}

    private string GetDebuggerDisplay()
    {
        return ToString();
    }