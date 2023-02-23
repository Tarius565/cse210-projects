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
        SpinnerTime(1);
        Console.WriteLine();
        Console.WriteLine(_description);
        SpinnerTime(2);

    }

    public void DisplayEnd()
    {
        SetMessageEnd();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(_finish);
        SpinnerTime(1);
        Console.WriteLine();
        Console.WriteLine(_messageEnd);
        SpinnerTime(2);
    }

    public void SpinnerTime(int time)
    {
        int seconds = time * 4;
        for (int i=0; i<seconds; i++)
        {
            switch (i % 4)
            {
                case 0:
                    Console.Write("-");
                    break;
                case 1:
                    Console.Write(@"\");
                    break;
                case 2:
                    Console.Write("|");
                    break;
                case 3:
                    Console.Write("/");
                    break;
                default:
                    break;
            }
            Thread.Sleep(250);

            Console.Write("\b \b");
        }
    }

    public void TimerTime(int time)
    {
        for (int i=time; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");
        }
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DurationQuestion()
    {
        Console.WriteLine();
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
    
    public void ClearConsole()
    {
        Console.Clear();
    }
    
    public void ActivityStart()
    {
        ClearConsole();
        DisplayStart();
        DurationQuestion();
        ClearConsole();
        Console.WriteLine("Get ready...");
        SpinnerTime(3);
    }

    public void LogActivity()
    {

    }
}