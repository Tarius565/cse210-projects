using System;

public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Breathe out...";

    public BreathingActivity(string messageStart, string description, int duration, string messageEnd, string activity)
        : base(messageStart, description, duration, messageEnd, activity)
    {
    }

    public void DisplayBreathe()
    {

    }


}