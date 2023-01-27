using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int option;
        Menu userOptions = new Menu();
        Journal myJournal = new Journal();
        do 
        {
            option = userOptions.Run();
            // If statements for each of the option numbers (except 5)
            switch (option)
            {
                case 1:
                    PromptGenerator newPrompt = new PromptGenerator();
                    string prompt = newPrompt.Generate();

                    Console.WriteLine($"{prompt}");

                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;

                    myJournal._entry.Add(entry);
                    break;

                case 2:
                    myJournal.Display();
                    break;
                
                case 3:
                    List<string> loadedEntries = new List<string>();
                    loadedEntries = myJournal.Load();
                    
                    foreach (string i in loadedEntries)
                    {
                        string[] brokenLine = i.Split(new char[] {','}, 3);
                        Entry loadedEntry = new Entry();
                        loadedEntry._date = brokenLine[0];
                        loadedEntry._prompt = brokenLine[1];
                        loadedEntry._response = brokenLine[2];

                        myJournal._entry.Add(loadedEntry);
                    }
                    break;

                case 4:
                    myJournal.Save();
                    break;

                case 5:
                    break;

                default:
                    break;    
            }

        }while (option != 5);

        Console.WriteLine("Goodbye!");
    }
}