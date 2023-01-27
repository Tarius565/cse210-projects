using System;
using System.Collections.Generic;

public class PromptGenerator
{

    private List<string> _prompt = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

    public string Generate()
    {
        var random = new Random();
        int i = random.Next(_prompt.Count);

        string prompt = _prompt[i];

        return prompt;
    }
}