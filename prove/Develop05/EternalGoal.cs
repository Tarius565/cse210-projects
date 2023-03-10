using System;

public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points, bool achieved)
        : base (name, description, points, achieved)
        {
        }

    public override void RecordEvent()
    {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
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
    }



    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();

        stringRepresentation = $"EternalGoal:{name}|{desc}|{points}";
        
        return stringRepresentation;
    }

    public override bool IsComplete()
    {
        return GetAchieved();
    }
    
}
