using System;

public class Menu
{
    private List<string> _options = new List<string>{
        "1. Start breathing activity",
        "2. Start reflecting activity",
        "3. Start listing activity",
        "4. Quit"
    };

    private string _userInput;

    public string DisplayOptions()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        foreach(string opt in _options)
        {
            Console.WriteLine(opt);
        }
        Console.Write("Select a choice from the menu: ");
        _userInput = Console.ReadLine();

        while (!(_userInput =="1" || _userInput =="2" || _userInput =="3" || _userInput =="4"))
        {
            Console.WriteLine();
            Console.WriteLine("Wrong entry, try again");
            Console.WriteLine("Menu Options:");
            foreach(string opt in _options)
            {
                Console.WriteLine(opt);
            }
            Console.Write("Select a choice from the menu: ");
            _userInput = Console.ReadLine();
        }
        
        int inputOption = int.Parse(_userInput);
        string optionSelected;

        switch (inputOption)
        {
            case 1:
                optionSelected = "Breathing";
                break;
            
            case 2:
                optionSelected = "Reflecting";
                break;

            case 3:
                optionSelected = "Listing";
                break;

            case 4:
                optionSelected = "Quit";
                break;
            
            default:
                optionSelected = "Quit";
                break;
        }

        return optionSelected;
    }
}