using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num = -1;
        int sum = 0;
        int high = -100;
        int low = 100;
        float avg = 0;

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
                if (numbers[i] > high)
                {
                    high = numbers[i];
                }
                if (numbers[i] < low && numbers[i] > 0)
                {
                    low = numbers[i];
                }
            }
        
        avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is : {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {high}");
        Console.WriteLine($"The smallest positive number is: {low}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}