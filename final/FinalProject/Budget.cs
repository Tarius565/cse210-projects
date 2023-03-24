using System;

public class Budget
{
    private List<BudgetItem> _items;

    public Budget()
    {
        _items = new List<BudgetItem>();
    }

    public void AddItem(BudgetItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(BudgetItem item)
    {
        _items.Remove(item);
    }
    public void DisplayBudget()
    {
        foreach (BudgetItem item in _items)
        {
            if (item is Income)
            {
                item.DisplayDetails();
            }
        }
        foreach (BudgetItem item in _items)
        {
            if (item is Expense)
            {
                item.DisplayDetails();
            }
        }
        foreach (BudgetItem item in _items)
        {
            if (item is Savings)
            {
                item.DisplayDetails();
            }
        }
        foreach (BudgetItem item in _items)
        {
            if (item is Debt)
            {
                item.DisplayDetails();
            }
        }
    }

    public double GetTotalIncome()
    {
        double total = 0;
        foreach (BudgetItem item in _items)
        {
            if (item is Income)
            {
                total += item.GetAmount();
            }
        }
        return total;
    }

    public double GetTotalExpenses()
    {
        double total = 0;
        foreach (BudgetItem item in _items)
        {
            if (item is Expense)
            {
                total += item.GetAmount();
            }
        }
        return total;
    }

    public double GetTotalSavings()
    {
        double total = 0;
        foreach (BudgetItem item in _items)
        {
            if (item is Savings)
            {
                total += item.GetAmount();
            }
        }
        return total;
    }

    public double GetTotalDebt()
    {
        double total = 0;
        foreach (BudgetItem item in _items)
        {
            if (item is Debt)
            {
                total += item.GetAmount();
            }
        }
        return total;
    }

    public double GetRemainingBudget()
    {
        return GetTotalIncome() - GetTotalExpenses() - GetTotalSavings();
    }

    public IEnumerable<BudgetItem> GetItems()
    {
        return _items;
    }
}