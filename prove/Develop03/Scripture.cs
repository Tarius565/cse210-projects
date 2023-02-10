using System;
using System.Text.RegularExpressions;

public class Scritpure
{
    private string _reference;
    private string _fullText ="";
    private string _textLeft ="";
    private string _hiddenText ="";
    private string _textToDisplay ="";


    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void Initialize(string scritpureToMemorize)
    {
        _fullText = scritpureToMemorize;
        _textToDisplay = scritpureToMemorize;
        _textLeft = scritpureToMemorize;
    }

    public string GetTextLeft()
    {
        return _textLeft;
    }

    public void TextToDisplay()
    {
        Console.WriteLine($"{_reference} {_textToDisplay}");
    }

    public string GetWordToHide()
    {
        List<string> wordsList = new List<string>(_textLeft.Split(' '));
        var rnd = new Random();
        int index = rnd.Next(wordsList.Count);
        return wordsList[index];
    }

    public void ReplaceWholeWord(string wordToReplace, string replacementWord)
    {
        var pattern = $"\\b{wordToReplace}\\b";
        Regex.Replace(_textToDisplay, pattern, replacementWord, RegexOptions.IgnoreCase);

        Regex.Replace(_textLeft, pattern, "", RegexOptions.IgnoreCase);

        _hiddenText = _hiddenText + " " + wordToReplace;
    }



}


