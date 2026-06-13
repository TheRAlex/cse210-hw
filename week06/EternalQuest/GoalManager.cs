using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");

        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(
                new SimpleGoal(
                    name,
                    description,
                    points
                )
            );
        }

        else if (choice == "2")
        {
            _goals.Add(
                new EternalGoal(
                    name,
                    description,
                    points
                )
            );
        }

        else if (choice == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(
                new ChecklistGoal(
                    name,
                    description,
                    points,
                    target,
                    bonus
                )
            );
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");

        int choice = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[choice];

        bool wasComplete = goal.IsComplete();

        goal.RecordEvent();

        _score += goal.GetPoints();

        Console.WriteLine(
            $"You earned {goal.GetPoints()} points!"
        );

        if (goal is ChecklistGoal checklist)
        {
            if (!wasComplete && checklist.IsComplete())
            {
                _score += checklist.GetBonus();

                Console.WriteLine(
                    $"Bonus earned! +{checklist.GetBonus()} points!"
                );
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
   public void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                bool isComplete = bool.Parse(parts[4]);

                SimpleGoal goal =
                    new SimpleGoal(
                        name,
                        description,
                        points
                    );

                if (isComplete)
                {
                    goal.RecordEvent();
                }    

                _goals.Add(goal);
            }

            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                EternalGoal goal =
                    new EternalGoal(
                        name,
                        description,
                        points
                    );

                _goals.Add(goal);
            }

            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                int completed = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal =
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus
                    );

                goal.SetCompleted(completed);

                _goals.Add(goal);
            }
        }
    }
}    