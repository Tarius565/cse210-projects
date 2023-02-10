using System;

public class Reference
{
    private string _book;

    private string _chapter;

    private string _verse;

    public void SetReference(string fullReference)
    {
        string bookRef = fullReference.Split(":")[0].Trim();
        _book = bookRef.Substring(0,bookRef.LastIndexOf(" ")+1);
        _chapter =bookRef.Substring(bookRef.LastIndexOf(" ")+1);
        _verse = fullReference.Substring(fullReference.IndexOf(":")+1);

    }
        
    public string GetBook()
    {
        return _book;
    }    
    public string GetChapter()
    {
        return _chapter;
    }    
    public string GetVerse()
    {
        return _verse;
    }

}