using System;

public class BudgetManager
{
    private Budget _budget;

    public BudgetManager()
    {
        _budget = new Budget();
    }

    public void AddIncome(string name, double amount, string source)
    {
        Income income = new Income(name, amount, source);
        _budget.AddItem(income);
    }

    public void AddExpense(string name, double amount, string category)
    {
        Expense expense = new Expense(name, amount, category);
        _budget.AddItem(expense);
    }

    public void AddSavings(string name, double amount, string goal)
    {
        Savings savings = new Savings(name, amount, goal);
        _budget.AddItem(savings);
    }

    public void AddDebt(string name, double amount, string source)
    {
        Debt debt = new Debt(name, amount, source);
        _budget.AddItem(debt);
    }

    public void EditIncome(string name, double amount, string category)
    {
        Expense expense = new Expense(name, amount, category);
        _budget.AddItem(expense);
    }

    public void RemoveExpense(string name)
    {

    }
    public void DisplayBudget()
    {
        Console.WriteLine("Budget Details:");
        Console.WriteLine("==============================");
        _budget.DisplayBudget();
        Console.WriteLine("==============================");
        Console.WriteLine($"Total Income: {_budget.GetTotalIncome():C}");
        Console.WriteLine($"Total Expenses: {_budget.GetTotalExpenses():C}");
        Console.WriteLine($"Total Savings: {_budget.GetTotalSavings():C}");
        Console.WriteLine($"Total Debt: {_budget.GetTotalDebt():C}");
        Console.WriteLine($"Remaining Budget: {_budget.GetRemainingBudget():C}");
    }
}