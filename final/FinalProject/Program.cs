using System;

class Program
{
    static void Main(string[] args)
    {
        BudgetManager budgetManager = new BudgetManager();

        budgetManager.AddIncome("Paycheck", 2000.00, "Job");
        budgetManager.AddDebt("Student Loans", 200.00, "Tuition");
        budgetManager.AddExpense("Mortgage", 800.00, "Housing");
        budgetManager.AddSavings("Emergency Fund", 100.00, "Savings Account");
        budgetManager.AddExpense("Groceries", 200.00, "Food");

        budgetManager.DisplayBudget();
    }
}