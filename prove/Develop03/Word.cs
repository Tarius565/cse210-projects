using System;

public class Word
{
    private string _word;


    public void SetWord(string word)
    {
        _word = word;
    }

    public string Hide()
    {
        char[] letters = _word.ToCharArray();
        char[] hiddenLetters = new char[letters.Length];

        for(int i=0; i < letters.Length; i++)
        {
            if(Char.IsLetter(letters[i]))
            {
                hiddenLetters[i] = char.Parse("_");
            }
        }
        string hidden = new string(hiddenLetters);

        return hidden;
    }



}