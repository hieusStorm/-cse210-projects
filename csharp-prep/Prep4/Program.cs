using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        float average;
        int largestNumber = 0;
        string enteredNumber;

        Console.WriteLine("Please enter a list of numbers 1 at a time. (Enter 0 when you're done)");

        do
        {
            enteredNumber = Console.ReadLine();
            numbers.Add(int.Parse(enteredNumber));
        }
        while (enteredNumber != "0");

        foreach (int number in numbers)
        {
            sum = sum + number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The sum is {sum}");

        average = sum / numbers.Count();
        Console.WriteLine($"The average is {average}");

        Console.WriteLine($"The Largest number is {largestNumber}");
    }
}