using System;

public class BudgetMenu
{
    private BudgetManager _budgetManager;

    public BudgetMenu()
    {
        _budgetManager = new BudgetManager();
    }

    public void Start()
    {
        int choice = -1;
        int subChoice = 0;

        while(choice != 0)
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("Budget Manager");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add A Budget Item");
            Console.WriteLine("2. Edit A Budget Item");
            Console.WriteLine("3. Remove A Budget Item");
            Console.WriteLine("4. Show Summary");
            Console.WriteLine("5. Save Budget");
            Console.WriteLine("6. Load Budget");
            Console.WriteLine("0. Exit");
            Console.WriteLine("==============================");

            Console.Write("Enter your choice (0-6): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch(choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("Add Budget Item");
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Add Income");
                        Console.WriteLine("2. Add Expense");
                        Console.WriteLine("3. Add Savings");
                        Console.WriteLine("4. Add Debt");
                        Console.WriteLine("5. Return");
                        Console.WriteLine("==============================");

                        Console.Write("Enter your choice (1-5): ");
                        
                        input = Console.ReadLine();

                        if (int.TryParse(input, out subChoice))
                        {
                            switch(subChoice)
                            {
                                case 1:
                                    AddIncome();
                                    break;
                                case 2:
                                    AddExpense();
                                    break;
                                case 3:
                                    AddSavings();
                                    break;
                                case 4:
                                    AddDebt();
                                    break;
                                case 5:
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("Edit Budget Item");
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Edit Income");
                        Console.WriteLine("2. Edit Expense");
                        Console.WriteLine("3. Edit Savings");
                        Console.WriteLine("4. Edit Debt");
                        Console.WriteLine("5. Return");
                        Console.WriteLine("==============================");

                        Console.Write("Enter your choice (1-5): ");
                        
                        input = Console.ReadLine();

                        if (int.TryParse(input, out subChoice))
                        {
                            switch(subChoice)
                            {
                                case 1:
                                    EditIncome();
                                    break;
                                case 2:
                                    EditExpense();
                                    break;
                                case 3:
                                    EditSavings();
                                    break;
                                case 4:
                                    EditDebt();
                                    break;
                                case 5:
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("Remove Budget Item");
                        Console.WriteLine("==============================");
                        Console.WriteLine("1. Remove Income");
                        Console.WriteLine("2. Remove Expense");
                        Console.WriteLine("3. Remove Savings");
                        Console.WriteLine("4. Remove Debt");
                        Console.WriteLine("5. Return");
                        Console.WriteLine("==============================");

                        Console.Write("Enter your choice (1-5): ");
                        
                        input = Console.ReadLine();

                        if (int.TryParse(input, out subChoice))
                        {
                            switch(subChoice)
                            {
                                case 1:
                                    RemoveIncome();
                                    break;
                                case 2:
                                    RemoveExpense();
                                    break;
                                case 3:
                                    RemoveSavings();
                                    break;
                                case 4:
                                    RemoveDebt();
                                    break;
                                case 5:
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                        }
                        break;
                    case 4:
                        ShowSummary();
                        break;
                    case 5:
                        SaveBudget();
                        break;
                    case 6:
                        LoadBudget();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
    private void AddIncome()
    {
        Console.Write("Enter income name: ");
        string name = Console.ReadLine();

        Console.Write("Enter income amount: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter income source: ");
        string source = Console.ReadLine();

        _budgetManager.AddIncome(name, amount, source);

        Console.WriteLine($"Income '{name}' added successfully.");
    }
    private void AddExpense()
    {
        Console.Write("Enter expense name: ");
        string name = Console.ReadLine();

        Console.Write("Enter expense amount: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter expense category: ");
        string category = Console.ReadLine();

        _budgetManager.AddExpense(name, amount, category);

        Console.WriteLine($"Expense '{name}' added successfully.");
    }
    private void AddSavings()
    {
        Console.Write("Enter savings name: ");
        string name = Console.ReadLine();

        Console.Write("Enter savings amount: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter savings goal: ");
        string goal = Console.ReadLine();

        _budgetManager.AddSavings(name, amount, goal);

        Console.WriteLine($"Expense '{name}' added successfully.");
    }
    private void AddDebt()
    {
        Console.Write("Enter debt name: ");
        string name = Console.ReadLine();

        Console.Write("Enter debt amount: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter debt source: ");
        string source = Console.ReadLine();

        _budgetManager.AddDebt(name, amount, source);

        Console.WriteLine($"Expense '{name}' added successfully.");
    }
    private void EditIncome()
    {

    }
    private void EditExpense()
    {

    }
    private void EditSavings()
    {

    }
    private void EditDebt()
    {

    }
    private void RemoveIncome()
    {

    }
    private void RemoveExpense()
    {
        Console.Write("Enter expense name: ");
        string name = Console.ReadLine();

    }
    private void RemoveSavings()
    {

    }
    private void RemoveDebt()
    {

    }
    private void ShowSummary()
    {

    }
    private void SaveBudget()
    {

    }
    private void LoadBudget()
    {

    }
}