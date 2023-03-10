using System;

public class Menu
{
    private List<string> _menuOptions = new List<string>
    {
        "Menu Options:",
        "1. Create New Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit",
        "Select a choice from the menu: "
    };

    private List<string> _goalTypes = new List<string>
    {
        "The types of Goals are:",
        "1. Simple Goal",
        "2. Eternal Goal",
        "3. Checklist Goal",
        "4. Large Goal",
        "Which type of goal would you like to create? "
    };

    private int _menuSelection;
    private int _goalSelection;
    private int _recordSelection;


    public int RunMenu()
    {
        _menuSelection = 0;

        for (int i=0; i < _menuOptions.Count-1; i++)
        {
            Console.WriteLine(_menuOptions[i]);
            
                
            
        }
        while(true)
        {
            do 
            {
                Console.Write(_menuOptions.Last());
            }
            while (!int.TryParse(Console.ReadLine(), out _menuSelection));
        
            if ((_menuSelection<=6)&&(_menuSelection>=1))
            {
                break;
            }
        }
        
        return _menuSelection;
    }

    public int RunGoalMenu()
    {
        _goalSelection = 0;

        for (int i=0; i < _goalTypes.Count-1; i++)
        {
            Console.WriteLine(_goalTypes[i]);
            
                
            
        }
        while(true)
        {
            do 
            {
                Console.Write(_goalTypes.Last());
            }
            while (!int.TryParse(Console.ReadLine(), out _goalSelection));
        
            if ((_goalSelection<=4)&&(_goalSelection>=1))
            {
                break;
            }
        }
        return _goalSelection;
    }

    public int RunRecordMenu(List<string> goalNames)
    {
        _recordSelection = 0;
        // goalNames = new List<string>{};

        Console.WriteLine("The goals are:");
        for (int i=0; i < goalNames.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goalNames[i]}");
            
                
            
        }
        while(true)
        {
            do 
            {
                Console.Write("Which goal did you accomplish?: ");
            }
            while (!int.TryParse(Console.ReadLine(), out _recordSelection));
        
            if ((_recordSelection<=goalNames.Count)&&(_recordSelection>=1))
            {
                break;
            }
        }
        return _recordSelection;
    }

    public void SetGoalSelection(int selection)
    {
        _goalSelection = selection;
    }

    public void SetMenuSelection(int selection)
    {
        _menuSelection = selection;
    }

    public int GetGoalSelection()
    {
        return _goalSelection;
    }

    public int GetMenuSelection()
    {
        return _menuSelection;
    }
}