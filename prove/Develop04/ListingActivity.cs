using System;

public class ListingActivity : Activity
{
    private string _question;
    private string _questionInput;
    private int _numItems = 0;

    private List<string> _questionList = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _inputList = new List<string>{};

    public ListingActivity(string messageStart, string description, int duration, string messageEnd, string activity)
        : base(messageStart, description, duration, messageEnd, activity)
    {}

    public void SetQuestion()
    {
        Random rnd = new Random();
        int r = rnd.Next(_questionList.Count);
        _question = _questionList[r];
    }

    public string GetQuestion()
    {
        return _question;
    }

    public void DisplayQuestion()
    {
        SetQuestion();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---  {GetQuestion()}  ---");
    }

    public int GetNumItems()
    {
        return _numItems;
    }

    public void RetrieveInput()
    {
        Console.Write("You may begin in:");
        TimerTime(5);

        Console.WriteLine();

        int dur = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(dur);

        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            _questionInput = Console.ReadLine();
            _inputList.Add(_questionInput);
            _numItems++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_numItems} items!");
    }


}