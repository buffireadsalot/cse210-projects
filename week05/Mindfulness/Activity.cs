// Base Class
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! You have completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds on {_name}.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    protected void LogActivity(string details)
    {
        string logEntry = $"{DateTime.Now}: {_name}\n{details}\n";
        File.AppendAllText("activity_log.txt", logEntry);
    }

    public virtual void Run()
    {
        Console.WriteLine("This is a generic activity. Override this method in a subclass for specific behavior.");
    }
}