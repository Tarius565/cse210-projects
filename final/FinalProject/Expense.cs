using System;

public class Expense : BudgetItem
{
    private string _category;

    public Expense(string name, double amount, string category)
        : base(name, amount)
    {
        _category = category;
    }

    public string GetCategory()
    {
        return _category;
    }

    public void SetCategory(string category)
    {
        _category = category;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Type: {this.GetType()}, Name: {this.GetName()}, Amount: {this.GetAmount():C}, Category: {_category}");
    }
}