using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date = DateTime.Now.ToShortDateString();

    public void Display()
    {
        Console.WriteLine($"{_date}:{_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine();
    }

    public string Save()
    {
        return ($"{_date},{_prompt},{_response}");
    }

}