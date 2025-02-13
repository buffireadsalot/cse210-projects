class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _isCompleted ? $"[X] {_name}" : $"[ ] {_name}";
    }
}

