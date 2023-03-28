using System;

public abstract class BudgetItem
{
    private string _name;
    private double _amount;

    public BudgetItem(string name, double amount)
    {
        _name = name;
        _amount = amount;
    }
    public BudgetItem(){ }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public double GetAmount()
    {
        return _amount;
    }

    public void SetAmount(double amount)
    {
        _amount = amount;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}, Amount: {_amount:C}");
    }
}
