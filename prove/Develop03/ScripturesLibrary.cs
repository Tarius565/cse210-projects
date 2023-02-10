using System;
using System.Collections.Generic;

public class ScripturesLibrary
{
    private Dictionary<string, string> _scriptureDict = new Dictionary<string, string>()
        {
            {"Moses 1:39","For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."},
            {"Genesis 1:26-27","And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them."},
            {"John 3:5","Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot denter into the kingdom of God."},
            {"D&C 8:2-3","Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground."},
            {"1 Corinthians 5:13", "But them that are without God judgeth. Therefore put away from among yourselves that wicked person."}
        };

    public string GetScripture()
    {
        var rnd = new Random();
        var randomEntry = _scriptureDict.ElementAt(rnd.Next(0,_scriptureDict.Count));

        string reference = randomEntry.Key;
        string verse = randomEntry.Value;

        return reference + "|" + verse;
    }
}