// Reflecting Activity
class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() 
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Take a moment to think about it...");
        ShowSpinner(5);

        List<string> reflections = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine($"Question: {question}");
            ShowSpinner(5);
            Console.Write("Your response: ");
            reflections.Add(Console.ReadLine());
        }

        DisplayEndingMessage();

        LogActivity($"Duration: {_duration} seconds.\nPrompt: {prompt}\nReflections: {string.Join(", ", reflections)}");
    }
}