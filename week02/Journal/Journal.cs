using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Private field to store a list of entries
    private List<Entry> _entries;

    // Constructor to initialize the entries list
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method to add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    // Method to display all entries
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

    // Method to save entries to a file
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry.GetDate()}");
                outputFile.WriteLine($"Prompt: {entry.GetPromptText()}");
                outputFile.WriteLine($"Entry: {entry.GetEntryText()}");
                outputFile.WriteLine(); // Add a blank line between entries
            }
        }
        Console.WriteLine($"Journal entries saved to {fileName}");
    }

    // Method to load entries from a file
    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear(); // Clear current entries before loading
            string[] lines = File.ReadAllLines(fileName);

            for (int i = 0; i < lines.Length; i += 4) // Each entry spans 4 lines
            {
                if (i + 2 < lines.Length)
                {
                    string date = lines[i].Split(": ")[1];
                    string prompt = lines[i + 1].Split(": ")[1];
                    string entryText = lines[i + 2].Split(": ")[1];
                    _entries.Add(new Entry(date, prompt, entryText));
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