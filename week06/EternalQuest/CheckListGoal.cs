public class ChecklistGoal : Goal
{
    private int _target;
    private int _completed;
    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int target,
        int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = 0;
    }

    public override void RecordEvent()
    {
        _completed++;
    }

    public override bool IsComplete()
    {
        return _completed >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(_completed >= _target ? "X" : " ")}] {GetName()} -- Completed {_completed}/{_target}";
    }

     public int GetBonus()
    {
        return _bonus;
    }

    public void SetCompleted(int completed)
    {
    _completed = completed;
    }

    public override string GetStringRepresentation()
    {
    return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_completed},{_target},{_bonus}";
    }
}