using System;

class Program
{
    static void Main(string[] args)
    {

        // string finish = "Well done!!";
        // string start = "Welcome to the ";
        Menu menu = new Menu();

        string activity = menu.DisplayOptions();

        if (!(activity == "Quit"))
        {
            if (activity == "Breathing")
            {
                string messageStart = "Welcome to the Breathing Activity.";
                string desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                int duration = 0;
                string messageEnd = "";
                BreathingActivity breathing = new BreathingActivity(messageStart:messageStart, description:desc, duration:duration, messageEnd:messageEnd, activity:activity);

                breathing.DisplayStart();
                breathing.DurationQuestion();


            }
            else if (activity == "Reflecting")
            {

            }
            else if (activity == "Listing")
            {

            }



        }

















    }
}