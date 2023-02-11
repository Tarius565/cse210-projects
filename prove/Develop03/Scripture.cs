using System;
using System.Text.RegularExpressions;

public class Scritpure
{
    private string _reference;
    private string _fullText ="";
    private List<string> _textLeft = new List<string>();
    private List<string> _hiddenText = new List<string>();
    private string _textToDisplay ="";


    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void Initialize(string reference, string scritpureToMemorize)
    {
        SetReference(reference);
        _textToDisplay = scritpureToMemorize;
        _fullText = scritpureToMemorize;
        _textLeft = scritpureToMemorize.Split(' ').ToList();
    }

    public string GetTextLeft()
    {
        return String.Join(" ", _textLeft);
    }
    public int GetTextLeftNum()
    {
        return _textLeft.Count();
    }
    public string GetHiddenText()
    {
        return String.Join(" ", _hiddenText);
    }
    public string GetFullText()
    {
        return _fullText;
    }

    public void TextToDisplay()
    {
        Console.WriteLine($"{_reference} {_textToDisplay}");
    }

    public string GetWordToHide()
    {
        var rnd = new Random();
        int index = rnd.Next(_textLeft.Count);
        return _textLeft[index];
    }

    public void ReplaceWord(string wordToReplace, string replacementWord)
    {
        List<string> listOfTexts = new List<string>();
        listOfTexts = _textToDisplay.Split(" ").ToList();
        int index = listOfTexts.FindIndex(s => s == wordToReplace);
        if(index != -1)
        {
            listOfTexts[index] = replacementWord;
        }
        _textToDisplay = String.Join(" ", listOfTexts);

        _textLeft.Remove(wordToReplace);
        _hiddenText.Add(wordToReplace);
    }

}


