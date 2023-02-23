using System;

public class BreathingActivity : Activity
{
    // private string _breatheIn = "Breathe in...";
    // private string _breatheOut = "Breathe out...";

    public BreathingActivity(string messageStart, string description, int duration, string messageEnd, string activity)
        : base(messageStart, description, duration, messageEnd, activity)
    {
    }

    public void DisplayBreathe()
    {
        int dur = GetDuration();

        int breatheInDur = 4;
        int breatheOutDur = 6;
        int interval;

        int steps = dur / 10;
        int rem = dur % 10;
        if (steps == 0) 
        {
            steps++;
            rem = dur;
        }
        if (rem == 0)
        {
            steps--;
        }
        int remIn = rem / 2;
        int remOut = remIn;
        if (rem % 2 > 0)
        {
            remOut++;
        }

        Console.Write("Breathe in and out with the expanding line in ");
        TimerTime(3);
        Console.WriteLine();

        for (int i = 0; i <= steps; i++)
        {
            int breatheInTime = breatheInDur;
            int breatheOutTime = breatheOutDur;
            int lines = 0;
            if (i == 0 && rem > 0)
            {
                breatheInTime = remIn;
                breatheOutTime = remOut;

            }

            interval = breatheInTime;

            while (!(interval == 0))
            {
                for (int y = 0; y < 1000; y = y + 50)
                {
                    Console.Write("|");
                    lines++;
                    Thread.Sleep(50);

                }

                interval--;

            }

            for (int a = 0; a < lines; a++)
            {
                int sleep = 1000 / (lines / breatheOutTime);
                Console.Write("\b \b");
                Thread.Sleep(sleep);
                
            }
        }
        // for (int i = 0; i <= steps; i++)
        // {
        //     int breatheInTime = breatheInDur;
        //     int breatheOutTime = breatheOutDur;
        //     if (i == 0 && rem > 0)
        //     {
        //         breatheInTime = remIn;
        //         breatheOutTime = remOut;

        //     }

        //     Console.WriteLine();
        //     interval = breatheInTime;
        //     Console.WriteLine();
        //     Console.Write(_breatheIn + breatheInTime);
        //     while (!(interval == 0))
        //     {
                
        //         Thread.Sleep(1000);

        //         interval--;

        //         Console.Write("\b \b");
        //         Console.Write(interval);
        //     }
        //     Console.Write("\b \b");

        //     interval = breatheOutTime;
        //     Console.WriteLine();
        //     Console.Write(_breatheOut + breatheOutTime);
        //     while (!(interval == 0))
        //     {
                
        //         Thread.Sleep(1000);
        //         interval--;

        //         Console.Write("\b \b");
        //         Console.Write(interval);
        //     }
        //     Console.Write("\b \b");
        // }
    }


}