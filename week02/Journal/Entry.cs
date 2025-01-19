using System;

public class Entry
{
    // Fields to store date, prompt, and entry text
    public string Date;
    public string PromptText;
    public string EntryText;

    // Constructor to initialize the entry
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
        Console.WriteLine();
    }
}
