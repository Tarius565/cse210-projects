using System;

public class LargeGoal : Goal
{
    private int _steps;
    private int _stepsCompleted;
    private List<string> _subGoalNames = new List<string>();
    private List<int> _bonusPoints = new List<int>();
    private List<string> _subGoals = new List<string>();
    private List<bool> _subGoalAchieved = new List<bool>();

    public LargeGoal(string name, string description, int points, bool achieved, int steps, int stepsCompleted)
        : base(name, description, points, achieved)
    {
        _steps = steps;
        _stepsCompleted = stepsCompleted;
    }
    public void LargeGoalInit(out int steps, out string subGoals)
    {
        _steps = 0;
        _stepsCompleted = 0;
        _subGoals.Clear();
        _subGoalNames.Clear();
        _bonusPoints.Clear();
        _subGoalAchieved.Clear();
        int bonus;
        bool subAchieved = false;
        subGoals = "";
        do 
            {
                Console.Write("How many steps does this goal require?: ");
            }
            while (!int.TryParse(Console.ReadLine(), out steps));

        _steps = steps;

        for (int i = 0; i < steps; i++)
        {
            Console.Write($"What is step number {i+1}'s goal?: ");
            string goal = Console.ReadLine();
            do 
            {
                Console.Write("What is the bonus for accomplishing this step?: ");
            }
            while (!int.TryParse(Console.ReadLine(), out bonus));

            string sub = $"~{i+1}~{goal}~{bonus}~{subAchieved}";
            subGoals += sub;
            _subGoals.Add(sub);
            _subGoalNames.Add(goal);
            _bonusPoints.Add(bonus);
            _subGoalAchieved.Add(subAchieved);
        }
    }
    
    public override string Display()
    {
        string name = GetName();
        string desc = GetDesc();
        string complete = "[ ]";
        string subComplete = "[ ]";
        if (IsComplete())
        {
            complete = "[X]";
        }
        string displayString = ($"{complete} {name} ({desc}) -- steps to complete:");
        for (int i = 1; i <= _subGoalNames.Count; i++)
        {
            if (i <= _stepsCompleted)
            {
                subComplete = "[x]";
            }
            else {subComplete = "[ ]";}
            displayString += ($"\n\t {subComplete} {i}. {_subGoalNames[i-1]}");
        }

        return displayString;
    }
    public override void RecordEvent()
    {
        
        if (!(IsComplete())&&(GetStepsCompleted()<GetSteps()))
        {
            Console.WriteLine($"Congratulations! You have earned {GetSubPoints(GetStepsCompleted())} points!");
            int complete = GetStepsCompleted() + 1;
            SubGoalAchieved(GetStepsCompleted());
            SetStepsCompleted(complete);
            if ((IsComplete())&&(GetStepsCompleted()==GetSteps()))
            {
                Console.WriteLine($"Congratulations on completing the large goal! You earned a bonus of {GetPoints()} points!");
                bool achieved = true;
                SetAchieved(achieved);

            }
        }
    }

    public int AddSubPoints()
    {
        return _bonusPoints[GetStepsCompleted()-1];
    }

    public override void SetStringRepresentation(string goalLine)
    {
        int index = goalLine.IndexOf(":");
        if (index >= 0)
            goalLine = goalLine.Substring(index + 1);

        // string[] parts = Regex.Split(goalLine, @"(?<=[|])");
        string[] parts = goalLine.Split("|");
        SetName(parts[0]);
        SetDesc(parts[1]);
        SetPoints(int.Parse(parts[2]));
        SetStepsCompleted(int.Parse(parts[3]));
        SetSteps(int.Parse(parts[4]));
        SetAchieved(bool.Parse(parts[5]));
        string subGoalsInput = parts[6];

        string[] subGoalParts = subGoalsInput.Split("~");
        _subGoals.Clear();
        _subGoalNames.Clear();
        _subGoalAchieved.Clear();
        _bonusPoints.Clear();

        subGoalParts = subGoalParts.Skip(1).ToArray();
        for(int i = 0; i < subGoalParts.Length; i+=4)
        {
            int num = (i/4)+1;
            string goal = subGoalParts[i+1];
            int bonus = int.Parse(subGoalParts[i+2]);
            bool subAchieved = bool.Parse(subGoalParts[i+3]);

            string sub = $"~{num}~{goal}~{bonus}~{subAchieved}";

            _subGoals.Add(sub);
            _subGoalNames.Add(goal);
            _bonusPoints.Add(bonus);
            _subGoalAchieved.Add(subAchieved);
        }

    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();
        int stepsCompleted = GetStepsCompleted();
        int steps = GetSteps();
        bool achieved = GetAchieved();
        string subGoals = string.Join("",GetSubGoals().ToArray());

        stringRepresentation = $"LargeGoal:{name}|{desc}|{points}|{stepsCompleted}|{steps}|{achieved}|{subGoals}";
        
        return stringRepresentation;
    }

    public override bool IsComplete()
    {
        return GetStepsCompleted()==GetSteps();
    }

    public string DisplaySubGoal()
    {
        string displayString =" -- Subgoals completed";
        if (!(IsComplete()))
        {
            displayString = ($"\n\t {_subGoalNames[_stepsCompleted]} -- Next to complete");

        }
        return displayString;
    }

    public int GetSubPoints(int value)
    {
        return _bonusPoints[value];
    }

    public int GetSteps()
    {
        return _steps;
    }

    public void SetSteps(int steps)
    {
        _steps = steps;
    }

    public int GetStepsCompleted()
    {
        return _stepsCompleted;
    }

    public void SetStepsCompleted(int stepsCompleted)
    {
        _stepsCompleted = stepsCompleted;
    }

    public List<string> GetSubGoals()
    {
        return _subGoals;
    }

    public void SetSubGoalNames(string subGoals)
    {
        _subGoals.Add(subGoals);
    }

    public void SubGoalAchieved(int loc)
    {
        _subGoalAchieved[loc] = true;
    }

}