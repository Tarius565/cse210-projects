using System;

public class Savings : BudgetItem
{
    public string _goal;

    public Savings(string name, double amount, string goal) : base(name, amount)
    {
        _goal = goal;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public void SetGoal(string goal)
    {
        _goal = goal;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Type: {this.GetType()}, Name: {this.GetName()}, Amount: {this.GetAmount():C}, Goal: {_goal}");
    }
}