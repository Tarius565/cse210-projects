using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _currentComplete;
    private int _times;
    public ChecklistGoal(string name, string description, int points, bool achieved, int bonus, int current, int times)
        : base(name, description, points, achieved)
    {
        _bonus = bonus;
        _currentComplete = current;
        _times = times;
    }
    public void ChecklistGoalInit(out int number, out int bonus)
    {
        do 
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            }
            while (!int.TryParse(Console.ReadLine(), out number));
        do 
            {
                Console.Write("What is the bonus for accomplishing it that many times?: ");
            }
            while (!int.TryParse(Console.ReadLine(), out bonus));

        SetTimes(number);
        SetBonus(bonus);
    }

    public override string Display()
    {
        string name = GetName();
        string desc = GetDesc();
        string complete = "[ ]";
        if (IsComplete())
        {
            complete = "[X]";
        }
        string displayString = ($"{complete} {name} ({desc}) -- Currently completed: {_currentComplete}/{_times}");

        return displayString;
    }
    
    public override void RecordEvent()
    {
        if (!(IsComplete())&&(GetCurrent()<GetTimes()))
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            int complete = GetCurrent() + 1;
            SetCurrent(complete);
            if (!(IsComplete())&&(GetCurrent()==GetTimes()))
            {
                Console.WriteLine($"Congratulations on completing the checklist goal! You earned a bonus of {GetBonus()} points!");
                bool achieved = true;
                SetAchieved(achieved);

            }   
        }
                 
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
        SetBonus(int.Parse(parts[3]));
        SetCurrent(int.Parse(parts[4]));
        SetTimes(int.Parse(parts[5]));
        SetAchieved(bool.Parse(parts[6]));

    }



    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();
        bool achieved = GetAchieved();
        int bonus = GetBonus();
        int current = GetCurrent();
        int times = GetTimes();

        stringRepresentation = $"ChecklistGoal:{name}|{desc}|{points}|{bonus}|{current}|{times}|{achieved}";
        
        return stringRepresentation;
    }

    public override bool IsComplete()
    {
        return GetAchieved();
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetCurrent()
    {
        return _currentComplete;
    }

    public void SetCurrent(int current)
    {
        _currentComplete = current;
    }

    public int GetTimes()
    {
        return _times;
    }

    public void SetTimes(int times)
    {
        _times = times;
    }

}