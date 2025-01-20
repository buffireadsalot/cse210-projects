public class PromptGenerator
{
    // Private field to store the list of prompts
    private List<string> _prompts;

    // Constructor to initialize the list of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What would it be if I had one thing I could do over today?"
        };
    }

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}