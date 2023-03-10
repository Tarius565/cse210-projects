using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int menuOption;
        int goalOption;
        List<string> goals = new List<string>{};
        List<string> goalDisplay = new List<string>{};
        List<string> goalNames = new List<string>{};
        string name = "";
        string desc = "";
        int points = 0;
        bool achieved = false;
        int times = 0;
        int bonus = 0;
        int current = 0;
        int steps = 0;
        string subGoals = "";
        int stepsCompleted = 0;

        int currentPoints = 0;
        
        SimpleGoal newSimpleGoal = new SimpleGoal(name, desc, points, achieved);
        EternalGoal newEternalGoal = new EternalGoal(name, desc, points, achieved);
        ChecklistGoal newChecklistGoal = new ChecklistGoal(name, desc, points, achieved, bonus, current, times);
        LargeGoal newLargeGoal = new LargeGoal(name, desc, points, achieved, steps, stepsCompleted);
        SaveLoad saveLoad = new SaveLoad();

        do
        {
            Console.WriteLine();
            WritePoints(currentPoints);
            Console.WriteLine();
            menuOption = menu.RunMenu();

            switch(menuOption)
            {
                case 1:
                    goalOption = menu.RunGoalMenu();
                            
                    switch(goalOption)
                    {
                        case 1:
                            newSimpleGoal.GoalInit(out name, out desc, out points);
                            goals.Add(newSimpleGoal.GetStringRepresentation());
                            goalDisplay.Add(newSimpleGoal.Display());
                            goalNames.Add(name);
                            break;
                        case 2:
                            newEternalGoal.GoalInit(out name, out desc, out points);
                            goals.Add(newEternalGoal.GetStringRepresentation());
                            goalDisplay.Add(newEternalGoal.Display());
                            goalNames.Add(name);
                            break;
                        case 3:
                            newChecklistGoal.GoalInit(out name, out desc, out points);
                            newChecklistGoal.ChecklistGoalInit(out times, out bonus);
                            goals.Add(newChecklistGoal.GetStringRepresentation());
                            goalDisplay.Add(newChecklistGoal.Display());
                            goalNames.Add(name);
                            break;
                        case 4:
                            newLargeGoal.GoalInit(out name, out desc, out points);
                            newLargeGoal.LargeGoalInit(out steps, out subGoals);
                            goals.Add(newLargeGoal.GetStringRepresentation());
                            goalDisplay.Add(newLargeGoal.Display());
                            goalNames.Add($"{name}{newLargeGoal.DisplaySubGoal()}");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("The goals are:");
                    for (int i = 1; i <= goalDisplay.Count; i++)
                    {
                        Console.WriteLine($"{i}. {goalDisplay[i-1]}");
                        
                    }
                    break;
                case 3:
                    saveLoad.Save(currentPoints, goals);

                    break;
                case 4:
                    saveLoad.Load(out currentPoints, out goals);
                    int identifier = 0;
                    string goalTypeLoad = "";
                    foreach(string goal in goals)
                    {
                        identifier = goal.IndexOf(":");
                        if (identifier >= 0)
                            goalTypeLoad = goal.Substring(0,identifier);
                        
                        if (goalTypeLoad == "SimpleGoal")
                        {
                            newSimpleGoal.SetStringRepresentation(goal);
                            goalDisplay.Add(newSimpleGoal.Display());
                            if (newSimpleGoal.GetAchieved())
                            {
                                goalNames.Add($"{newSimpleGoal.GetName()}{newSimpleGoal.DisplayCompleted()}");
                            }
                            else
                            {
                                goalNames.Add(newSimpleGoal.GetName());
                            }
                        }
                        else if (goalTypeLoad == "EternalGoal")
                        {
                            newEternalGoal.SetStringRepresentation(goal);
                            goalDisplay.Add(newEternalGoal.Display());
                            
                        }
                        else if (goalTypeLoad == "ChecklistGoal")
                        {
                            newChecklistGoal.SetStringRepresentation(goal);
                            goalDisplay.Add(newChecklistGoal.Display());
                            if (newChecklistGoal.GetAchieved())
                            {
                                goalNames.Add($"{newChecklistGoal.GetName()}{newChecklistGoal.DisplayCompleted()}");
                            }
                            else
                            {
                                goalNames.Add(newChecklistGoal.GetName());
                            }
                        }
                        else if (goalTypeLoad == "LargeGoal")
                        {
                            newLargeGoal.SetStringRepresentation(goal);
                            goalDisplay.Add(newLargeGoal.Display());
                            goalNames.Add($"{newLargeGoal.GetName()}{newLargeGoal.DisplaySubGoal()}");
                        }
                    }
                    break;
                case 5:
                    int goalNumber = menu.RunRecordMenu(goalNames) - 1;
                    string goalLine = goals[goalNumber];
                    string goalType = "";
                    int index = goalLine.IndexOf(":");
                    if (index >= 0)
                        goalType = goalLine.Substring(0,index);
                    
                    if (goalType == "SimpleGoal")
                    {
                        newSimpleGoal.SetStringRepresentation(goalLine);
                        if (!(newSimpleGoal.IsComplete()))
                        {
                            newSimpleGoal.RecordEvent();
                            goals[goalNumber] = newSimpleGoal.GetStringRepresentation();
                            goalDisplay[goalNumber] = newSimpleGoal.Display();
                            goalNames[goalNumber] = $"{newSimpleGoal.GetName()}{newSimpleGoal.DisplayCompleted()}";
                            currentPoints += newSimpleGoal.AddPoints();
                            Console.WriteLine($"You now have {currentPoints} points.");
                        }
                    }
                    else if (goalType == "EternalGoal")
                    {
                        newEternalGoal.SetStringRepresentation(goalLine);
                        newEternalGoal.RecordEvent();
                        goals[goalNumber] = newEternalGoal.GetStringRepresentation();
                        goalDisplay[goalNumber] = newEternalGoal.Display();
                        currentPoints += newEternalGoal.AddPoints();
                        Console.WriteLine($"You now have {currentPoints} points.");
                        
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        newChecklistGoal.SetStringRepresentation(goalLine);
                        if (!(newChecklistGoal.IsComplete()))
                        {
                            newChecklistGoal.RecordEvent();
                            goals[goalNumber] = newChecklistGoal.GetStringRepresentation();
                            goalDisplay[goalNumber] = newChecklistGoal.Display();
                            currentPoints += newChecklistGoal.AddPoints();
                            if (newChecklistGoal.GetAchieved())
                            {
                                goalNames[goalNumber] = $"{newChecklistGoal.GetName()}{newChecklistGoal.DisplayCompleted()}";
                                currentPoints += newChecklistGoal.GetBonus();
                            }
                            Console.WriteLine($"You now have {currentPoints} points.");
                        }
                    }
                    else if (goalType == "LargeGoal")
                    {
                        newLargeGoal.SetStringRepresentation(goalLine);
                        if (!(newLargeGoal.IsComplete()))
                        {
                            newLargeGoal.RecordEvent();
                            goals[goalNumber] = newLargeGoal.GetStringRepresentation();
                            goalDisplay[goalNumber] = newLargeGoal.Display();
                            goalNames[goalNumber] = $"{newLargeGoal.GetName()}{newLargeGoal.DisplaySubGoal()}";
                            currentPoints += newLargeGoal.AddSubPoints();
                            if (newLargeGoal.GetAchieved())
                            {
                                currentPoints += newLargeGoal.AddPoints();
                            }
                            Console.WriteLine($"You now have {currentPoints} points.");
                        }
                    }
                    break;    
                case 6:
                    break;        
                default:
                    break;
            }
        }
        while (!(menuOption==6));
    }



    private static void WritePoints(int points)
    {
        Console.WriteLine($"You have {points} points.");
    }

}