using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

 


class Program

{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string fileName = "journal.txt"; // Default file name for saving/loading
        string userChoice = "";

        List<string> menuItems = new List<string>
        {
            "1. Add Entry",
            "2. Load File",
            "3. Save File",
            "4. Display Journal",
            "5. Quit"
        };

        while (userChoice != "5") // Loop until the user chooses "5"
        {
            Console.Clear(); // Clear the console for a clean menu display
            Console.WriteLine("=== Main Menu ===");

            // Display the menu
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nChoose an option (1-5): ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Write("Enter a prompt: ");
                string prompt = Console.ReadLine();

                Console.Write("Enter your response: ");
                string response = Console.ReadLine();

                Entry newEntry = EntryText(prompt, response);
                journal.AddEntry(EntryText);
            }
            else if (userChoice == "2")
            {
                journal.LoadFromFile(fileName);
            }
            else if (userChoice == "3")
            {
                journal.SaveToFile(fileName);
            }
            else if (userChoice == "4")
            {
                journal.DisplayAll();
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option (1-5).");
            }

            if (userChoice != "5") // Pause if the user hasn't chosen to quit
            {
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}

