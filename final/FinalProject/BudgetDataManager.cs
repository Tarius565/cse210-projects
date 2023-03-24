using System;
using System.IO;
using System.Collections.Generic;

public class BudgetDataFileManager
{
    private string filePath;

    public BudgetDataFileManager(string filePath)
    {
        this.filePath = filePath;
    }

    public void SaveBudgetData(List<Budget> budgetList)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Budget budget in budgetList)
            {
                // writer.WriteLine($"{budget._name}|{budget._category}|{budget._amount}");
            }
        }
    }

    public List<Budget> LoadBudgetData()
    {
        List<Budget> budgetList = new List<Budget>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] values = line.Split('|');

                Budget budget = new Budget();
                // budget._name = values[0];
                // budget._category = values[1];
                // budget._amount = Convert.ToDouble(values[2]);

                budgetList.Add(budget);
            }
        }

        return budgetList;
    }
}