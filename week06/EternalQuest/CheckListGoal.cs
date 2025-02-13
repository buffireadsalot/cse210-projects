class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int Bonus { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        Bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                _isCompleted = true;
                return _points + Bonus;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _isCompleted ? $"[X] {_name} ({CurrentCount}/{TargetCount})"
                           : $"[ ] {_name} ({CurrentCount}/{TargetCount})";
    }

    public void RenewGoal()
    {
        CurrentCount = 0;
        _isCompleted = false;
    }
}