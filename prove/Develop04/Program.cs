using System;

class Program
{
    static void Main(string[] args)
    {

        string messageStart ="";
        string desc = "";
        int duration = 0;
        string messageEnd = "";

        Menu menu = new Menu();
        string activity;

        do
        {
                
            activity = menu.DisplayOptions();

            if (activity == "Breathing")
            {
                messageStart = "Welcome to the Breathing Activity.";
                desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                duration = 0;
                messageEnd = "";

                BreathingActivity breathing = new BreathingActivity(messageStart:messageStart, description:desc, duration:duration, messageEnd:messageEnd, activity:activity);

                breathing.ActivityStart();
                breathing.DisplayBreathe();
                breathing.DisplayEnd();

            }
            else if (activity == "Reflecting")
            {
                messageStart = "Welcome to the Reflecting Activity.";
                desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                duration = 0;
                messageEnd = "";

                ReflectingActivity reflecting = new ReflectingActivity(messageStart:messageStart, description:desc, duration:duration, messageEnd:messageEnd, activity:activity);
                reflecting.ActivityStart();
                reflecting.DisplayRandomPrompt();
                reflecting.RunReflectingQuestions();
                reflecting.DisplayEnd();

            }
            else if (activity == "Listing")
            {
                messageStart = "Welcome to the Listing Activity.";
                desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                duration = 0;
                messageEnd = "";

                ListingActivity listing = new ListingActivity(messageStart:messageStart, description:desc, duration:duration, messageEnd:messageEnd, activity:activity);
                listing.ActivityStart();
                listing.DisplayQuestion();
                listing.RetrieveInput();
                listing.DisplayEnd();

            }
        }
        while (!(activity == "Quit"));


    }
}