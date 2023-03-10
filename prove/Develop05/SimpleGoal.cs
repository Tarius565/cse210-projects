using System;
using System.Text.RegularExpressions;

public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points, bool achieved)
        : base (name, description, points, achieved)
        {
        }

    public override void RecordEvent()
    {
        if (!(IsComplete()))
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            bool achieved = true;
            SetAchieved(achieved);

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
        SetAchieved(bool.Parse(parts[3]));
    }


    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";
        string name = GetName();
        string desc = GetDesc();
        int points = GetPoints();
        bool achieved = GetAchieved();

        stringRepresentation = $"SimpleGoal:{name}|{desc}|{points}|{achieved}";
        
        return stringRepresentation;
    }

    public override bool IsComplete()
    {
        return GetAchieved();
    }

}