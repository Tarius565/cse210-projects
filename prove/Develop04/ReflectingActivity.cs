using System;

public class ReflectingActivity : Activity
{
    private string _prompt;

    private List<string> _questionSelectedList = new List<string> {};

    private List<string> _promptList = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questionList = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string messageStart, string description, int duration, string messageEnd, string activity)
        : base(messageStart, description, duration, messageEnd, activity)
    {}

    public void SetPrompt()
    {
        Random rnd = new Random();
        int r = rnd.Next(_promptList.Count);
        _prompt = _promptList[r];

    }

    public void DisplayRandomPrompt()
    {
        SetPrompt();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---  {_prompt}  ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

    }

    public void SelectQuestions(int num)
    {
        Random rnd = new Random();

        List<int> listNumbers = new List<int>();
        int number;

        for (int i = 0; i < num; i++)
        {
            do {
                number = rnd.Next(_questionList.Count);
            } while (listNumbers.Contains(number));
            listNumbers.Add(number);
        }
        for (int j = 0; j < num; j++)
        {
            _questionSelectedList.Add(_questionList[listNumbers[j]]);
        }
    }

    public void RunReflectingQuestions()
    {
        int dur = GetDuration();
        int numOfQuestions = dur / 10;
        if (numOfQuestions > _questionList.Count)
        {
            numOfQuestions = _questionList.Count;
        }
        if (numOfQuestions == 0){numOfQuestions = 1;}
        double timePerQuestion = dur / (double)numOfQuestions;

        SelectQuestions(numOfQuestions);

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");

        TimerTime(5);

        Console.Clear();

        foreach (string question in _questionSelectedList)
        {
            Console.Write(question);
            SpinnerTime((int)timePerQuestion);
            Console.WriteLine();
        }
    }


}