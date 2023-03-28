using System;
using System.IO;
using System.Collections.Generic;

public class BudgetDataFileManager
{
    private string filePath;
    private string fileType = ".csv";

    public BudgetDataFileManager(string filePath)
    {
        this.filePath = filePath;
    }

    public void SaveBudgetData(List<BudgetItem> budgetList)
    {
        using (StreamWriter writer = new StreamWriter(filePath+fileType))
        {
            foreach (BudgetItem budget in budgetList)
            {
                writer.Write($"{budget}:{budget.GetName()}|{budget.GetAmount()}|");
                if (budget is Income income)
                {
                    writer.WriteLine($"{income.GetSource()}");
                }
                else if (budget is Expense expense)
                {
                    writer.WriteLine($"{expense.GetCategory()}");
                }
                else if (budget is Savings savings)
                {
                    writer.WriteLine($"{savings.GetGoal()}");
                }
                else if (budget is Debt debt)
                {
                    writer.WriteLine($"{debt.GetSource()}");
                }
            }
        }
    }

    public List<BudgetItem> LoadBudgetData()
    {
        List<BudgetItem> budgetList = new List<BudgetItem>();

        using (StreamReader reader = new StreamReader(filePath+fileType))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(':');
                var type = values[0];
                var data = values[1].Split('|');
                string name = data[0];
                double amount = double.Parse(data[1]);

                switch (type)
                {
                    case "Income":
                        string IncomeSource = data[2];
                        Income income = new Income(name, amount, IncomeSource);
                        budgetList.Add(income);
                        break;
                    case "Expense":
                        string category = data[2];
                        Expense expense = new Expense(name, amount, category);
                        budgetList.Add(expense);
                        break;
                    case "Savings":
                        string goal = data[2];
                        Savings savings = new Savings(name, amount, goal);
                        budgetList.Add(savings);
                        break;
                    case "Debt":
                        string debtSource = data[2];
                        Debt debt = new Debt(name, amount, debtSource);
                        budgetList.Add(debt);
                        break;
                    default:
                        break;
                }
            }
        }

        return budgetList;
    }
}