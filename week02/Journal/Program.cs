class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string fileName = "Journal.txt";
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("\n=== Main Menu ===");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                journal.AddEntry(new Entry(DateTime.Now.ToShortDateString(), prompt, response));
            }
            else if (userChoice == "2")
            {
                journal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                journal.SaveToFile(fileName);
            }
            else if (userChoice == "4")
            {
                journal.LoadFromFile(fileName);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
