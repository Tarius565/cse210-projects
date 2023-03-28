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

    public void EditItem(BudgetItem item)
    {
        int index = -1;
        string name = item.GetName();
        
        for (int i = 0; i < _items.Count(); i++)
        {
            if (_items[i].GetName() == name)
            {
                index = i;
            }
        }
        if (index == -1)
        {
            Console.WriteLine($"Item {name} not found.");
        }
        else
        {
            _items[index] = item;
            Console.WriteLine($" Item {name} has been modified.");
            Console.WriteLine();
        }
    }

    public void RemoveItem(string name)
    {
        int index = -1;
        
        for (int i = 0; i < _items.Count(); i++)
        {
            if (_items[i].GetName() == name)
            {
                index = i;
            }
        }
        if (index == -1)
        {
            Console.WriteLine($"Item {name} not found.");
        }
        else
        {
            Console.WriteLine($" Item {name} has been deleted.");
            Console.WriteLine();
            _items.RemoveAt(index);
        }
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

    public void DisplayIncomes()
    {
        foreach (BudgetItem item in _items)
        {
            if (item is Income)
            {
                item.DisplayDetails();
            }
        }
    }

    public void DisplayExpenses()
    {
        foreach (BudgetItem item in _items)
        {
            if (item is Expense)
            {
                item.DisplayDetails();
            }
        }
    }

    public void DisplaySavings()
    {
        foreach (BudgetItem item in _items)
        {
            if (item is Savings)
            {
                item.DisplayDetails();
            }
        }
    }

    public void DisplayDebt()
    {
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
        return GetTotalIncome() - GetTotalExpenses();
    }

    public List<BudgetItem> GetItems()
    {
        return _items;
    }

    public void SetItems(List<BudgetItem> items)
    {
        _items = items;
    }

}