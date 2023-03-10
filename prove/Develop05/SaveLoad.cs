using System;
using System.IO;

public class SaveLoad
{
    private string _fileName = "";

    private string _file = ".txt";



    public void Save(int points, List<string> goals)
    {
        string location = FileRequest();

        using (StreamWriter outputFile = new StreamWriter(location))
        {
            outputFile.WriteLine(points);
            foreach(string goal in goals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }

    public void Load(out int points, out List<string> goals)
    {
        string location = FileRequest();

        string[] lines = System.IO.File.ReadAllLines(location);

        goals = new List<string>();
        points = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 0)
            {
                points = int.Parse(lines[i]);
            }
            else
            {
                goals.Add(lines[i]);
            }
        }
    }

    public string FileRequest()
    {
        Console.Write("What is the filename for the goal file? (ignore .txt) ");
        _fileName = Console.ReadLine();


        return _fileName + _file;
    }
}