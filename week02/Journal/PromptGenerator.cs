using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // A list to store the prompts
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
        int index = random.Next(_prompts.Count); // Get a random index
        return _prompts[index];
    }
      
        //return "";
       

}

