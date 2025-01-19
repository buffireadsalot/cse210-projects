using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List to store entries
    public List<Entry> _entries;

    // Constructor to initialize the list of entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            Console.WriteLine("\nJournal Entries:");
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Save journal entries to a file
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry.Date}");
                outputFile.WriteLine($"Prompt: {entry.PromptText}");
                outputFile.WriteLine($"Entry: {entry.EntryText}");
                outputFile.WriteLine(); // Add a blank line between entries
            }
        }
        Console.WriteLine($"Journal entries saved to {fileName}");
    }

    // Load journal entries from a file
    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear(); // Clear current entries before loading
            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i += 4) // Process 4 lines at a time (3 content + 1 blank)
            {
                if (i + 2 < lines.Length) // Ensure there are enough lines for an entry
                {
                    string[] dateParts = lines[i].Split(new[] { ": " }, StringSplitOptions.None);
                    string[] promptParts = lines[i + 1].Split(new[] { ": " }, StringSplitOptions.None);
                    string[] entryParts = lines[i + 2].Split(new[] { ": " }, StringSplitOptions.None);

                    if (dateParts.Length == 2 && promptParts.Length == 2 && entryParts.Length == 2)
                    {
                        string date = dateParts[1];
                        string prompt = promptParts[1];
                        string entryText = entryParts[1];

                        var entry = new Entry(prompt, entryText) { Date = date };
                        _entries.Add(entry);
                    }
                }
            }
            Console.WriteLine($"Journal entries loaded from {fileName}");
        }
        else
        {
            Console.WriteLine($"File {fileName} not found.");
        }
    }
}