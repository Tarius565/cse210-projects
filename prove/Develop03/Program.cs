using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        ScripturesLibrary newScripture = new ScripturesLibrary();
        string scripture = newScripture.GetScripture();

        string reference = scripture.Split('|')[0].Trim();
        string text = scripture.Substring(scripture.IndexOf("|")+1);

        Reference newReference = new Reference();
        newReference.SetReference(reference);

        Scritpure scritpureToMemorize = new Scritpure();

        scritpureToMemorize.Initialize(text);

        Word word = new Word();

        while (userInput != "quit")
        {
            Console.Write("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            string textLeft = scritpureToMemorize.GetTextLeft();
            int numToHide = 0;
            string wordToHide = "";
            string hiddenWord = "";

            int spaces = 1;
            for(int i =0; i < textLeft.Length; i++)
            {
                if(textLeft[i] == ' ')
                {
                    spaces++;
                }
            }
            if(spaces > 3)
            {
                Random rnd = new Random();
                numToHide = rnd.Next(1, 4);
            }
            else
            {
                numToHide = spaces;
            }
            
            for(int j=0; j < numToHide; j++)
            {
                wordToHide = scritpureToMemorize.GetWordToHide();
                word.SetWord(wordToHide);
                hiddenWord = word.Hide();
            }
            Console.Clear();
            scritpureToMemorize.ReplaceWholeWord(wordToHide, hiddenWord);
            scritpureToMemorize.TextToDisplay();
        }
        
    }
}