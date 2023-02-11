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

        scritpureToMemorize.Initialize(reference, text);
        int isEmpty = 1;

        Word word = new Word();
        
        scritpureToMemorize.TextToDisplay();

        while ((userInput != "quit") && (isEmpty != 0))
        {
            Console.Write("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            int textLeft = scritpureToMemorize.GetTextLeftNum();
            if(textLeft != 0)
            {
                int numToHide = 0;
                string wordToHide = "";
                string hiddenWord = "";
                int spaces = 1;
                
                if(textLeft > 3)
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
                    scritpureToMemorize.ReplaceWord(wordToHide, hiddenWord);
                }
                
                Console.Clear();
                scritpureToMemorize.TextToDisplay();
            }
            else
            {
                isEmpty = 0;
            }
        }
    }
}