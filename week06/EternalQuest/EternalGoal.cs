class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _points;  // Earn points every time
    }

    public override string GetStatus()
    {
        return $"[∞] {_name}";
    }
}
