public class Entry
{
    // Private fields
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor to initialize an entry
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    // Public getters for the fields (optional, if needed elsewhere)
    public string GetDate() => _date;
    public string GetPromptText() => _promptText;
    public string GetEntryText() => _entryText;
}
