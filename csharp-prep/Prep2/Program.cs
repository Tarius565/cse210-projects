using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        bool pass;
        string symbol = "";
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        float grade = float.Parse(gradeInput);

        if (grade >= 90)
        {
            letter = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letter = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letter = "C";
            pass = true;
        }
        else if (grade >= 60)
        {
            letter = "D";
            pass = false;
        }
        else
        {
            letter = "F";
            pass = false;
        }

        if (!(grade > 95 || grade < 60) && (grade % 10 >= 7 || grade % 10 <= 3))
        {
            if (grade % 10 >= 7)
            {
                symbol = "+";
            }
            else
            {
                symbol = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{symbol}");
        if (pass == true)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass.");
        }
    }
}