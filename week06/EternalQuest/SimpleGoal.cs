public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public override string GetDetailsString()
    {
        string box = _isComplete ? "[X]" : "[ ]";

        return $"{box} {GetName()}";
    }
    public override string GetStringRepresentation()
    {
    return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}