using System;

public class Activity
{
    private string _messageStart;
    private string _description;
    private int _duration;
    private string _messageEnd;
    private string _activity;
    private string _finish = "Well done!!";
    private string _start = "Welcome to the ";


    public Activity(string messageStart, string description, int duration, string messageEnd, string activity)
    {
        _messageStart = messageStart;
        _description = description;
        _duration = duration;
        _messageEnd = messageEnd;
        _activity = activity;
    }


    public void DisplayStart()
    {
        Console.WriteLine(_messageStart);
        Console.WriteLine();
        Console.WriteLine(_description);

    }

    public void DisplayEnd()
    {
        Console.WriteLine(_finish);
        Console.WriteLine();
        Console.WriteLine(_messageEnd);
    }

    public void SpinnerTime()
    {

    }

    public void TimerTime()
    {

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DurationQuestion()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        while (!(int.TryParse(durationInput, out int dur)))
        {
            Console.WriteLine();
            Console.WriteLine("Please enter in seconds how long you would like for your session: ");
            durationInput = Console.ReadLine();
        }
        _duration = int.Parse(durationInput);
    }

    public void SetMessageStart()
    {
        _messageStart = _start + _activity + " Activity.";
    }

    public void SetMessageEnd()
    {
        _messageEnd = $"You have completed another {_duration} seconds of the {_activity} Activity";
    }
}