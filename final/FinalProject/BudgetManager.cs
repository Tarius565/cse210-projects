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

    public void EditIncome(string name, double amount, string source)
    {
        Income income = new Income(name, amount, source);
        _budget.EditItem(income);
    }

    public void EditExpense(string name, double amount, string category)
    {
        Expense expense = new Expense(name, amount, category);
        _budget.EditItem(expense);
    }

    public void EditSavings(string name, double amount, string goal)
    {
        Savings savings = new Savings(name, amount, goal);
        _budget.EditItem(savings);
    }

    public void EditDebt(string name, double amount, string source)
    {
        Debt debt = new Debt(name, amount, source);
        _budget.EditItem(debt);
    }

    public void RemoveItem(string name)
    {
        _budget.RemoveItem(name);
    }
    public void DisplayIncomes()
    {
        _budget.DisplayIncomes();
    }

    public void DisplayExpenses()
    {
        _budget.DisplayExpenses();
    }

    public void DisplaySavings()
    {
        _budget.DisplaySavings();
    }

    public void DisplayDebt()
    {
        _budget.DisplayDebt();
    }

    public void DisplayBudget()
    {
        Console.WriteLine("Budget Details:");
        Console.WriteLine("==============================");
        _budget.DisplayBudget();
        Console.WriteLine("==============================");
        Console.WriteLine($"Total Income: {_budget.GetTotalIncome():C}");
        Console.WriteLine($"Total Expenses: -{_budget.GetTotalExpenses():C}");
        Console.WriteLine($"Total Savings: {_budget.GetTotalSavings():C}");
        Console.WriteLine($"Total Debt: {_budget.GetTotalDebt():C}");
        Console.WriteLine($"Remaining Budget: {_budget.GetRemainingBudget():C}");
        Console.WriteLine("==============================");
        Console.Write("Press any key to continue: ");
        Console.ReadLine();
    }

    public List<BudgetItem> GetList()
    {
        return _budget.GetItems();
    }

    public void SetList(List<BudgetItem> items)
    {
        _budget.SetItems(items);
    }
}