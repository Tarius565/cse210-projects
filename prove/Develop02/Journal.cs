using System;
using System.IO;

public class Journal
{
    public List<Entry> _entry = new List<Entry>();

    public List<string> _loadedEntry = new List<string>();

    private string filename;

    private string strFilePath = Directory.GetCurrentDirectory() + "/journal/";

    private string saveToFile;

    public void Display()
    {
        foreach (Entry entry in _entry)
        {
            entry.Display();
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the name of the csv file(omit .csv)?");
        filename = Console.ReadLine();

        saveToFile = strFilePath + filename +".csv";

        Console.WriteLine("Do you want to overwrite(1) or add to the end(2) of the file?");
        string overwrite = Console.ReadLine();

        if(!Directory.Exists(strFilePath))
        {
            Directory.CreateDirectory(strFilePath);
        }

        if(!File.Exists(saveToFile) || overwrite == "1")
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(saveToFile,FileMode.Create, FileAccess.Write)))
            {
                foreach (Entry entry in _entry)
                {
                    string value = entry.Save();
                    writer.WriteLine(value);
                }
            }
        }    
        else
        {
            using (StreamWriter writer = new StreamWriter(new FileStream(saveToFile,FileMode.Append, FileAccess.Write)))
            {
                foreach (Entry entry in _entry)
                {
                    string value = entry.Save();
                    writer.WriteLine(value);
                }
                
            }
        } 
        _entry.Clear();   
    }

    public List<string> Load()
    {
        Console.WriteLine("What is the name of the csv file(omit .csv)?");
        filename = Console.ReadLine();

        string pullFromFile = strFilePath + filename +".csv";

        try
        {
            string[] lines = File.ReadAllLines(pullFromFile);

            foreach (string line in lines)
            {
                _loadedEntry.Add(line);
            }
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine("An exception ({0}) occurred.",
                           e.GetType().Name);
            Console.WriteLine("Message:\n   {0}\n", e.Message);
        }
        
        return _loadedEntry;
    }

}