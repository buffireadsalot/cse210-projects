// Breathing Activity
class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through deep breathing.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++) // Assume 6 seconds per breath cycle
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
        DisplayEndingMessage();
    }
}
