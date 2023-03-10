using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _achieved;

    public Goal(string name, string description, int points, bool achieved)
    {
        _name = name;
        _description = description;
        _points = points;
        _achieved = achieved;
    }

    public abstract void RecordEvent();


    public void GoalInit(out string name, out string desc, out int points)
    {
        Console.Write("What is the name of your goal?: ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        desc = Console.ReadLine();
        do 
            {
                Console.Write("What is the amount of points associated with this goal?: ");
            }
            while (!int.TryParse(Console.ReadLine(), out points));

        _name = name;
        _description = desc;
        _points = points;
    }

    public virtual string Display()
    {
        string complete = "[ ]";
        if (IsComplete())
        {
            complete = "[X]";
        }
        string displayString = ($"{complete} {_name} ({_description})");

        return displayString;
    }

    public string DisplayCompleted()
    {
        string displayString = " -- Completed";
        return displayString;
    }

    public abstract string GetStringRepresentation();

    public virtual void SetStringRepresentation(string goalLine)
    {

    }

    public virtual bool IsComplete()
    {

        return _achieved;
    }
    public virtual int AddPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
    public bool GetAchieved()
    {
        return _achieved;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDesc(string description)
    {
        _description = description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetAchieved(bool achieved)
    {
        _achieved = achieved;
    }

}