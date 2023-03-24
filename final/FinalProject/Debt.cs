using System;

public class Debt : BudgetItem
{
    private string _source;

    public Debt(string name, double amount, string source) : base(name, amount)
    {
        _source = source;
    }

    public string GetSource()
    {
        return _source;
    }

    public void SetSource(string source)
    {
        _source = source;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Type: {this.GetType()}, Name: {this.GetName()}, Amount: {this.GetAmount():C}, Source: {_source}");
    }
}