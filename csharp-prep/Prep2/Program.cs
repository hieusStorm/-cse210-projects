using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int gradePercentage = int.Parse(userGrade);
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60) {
            letter = "D";
        }
        else if (gradePercentage < 60) {
            letter = "F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed your class.");
        }
        else 
        {
            Console.WriteLine("Better luck next time");
        }

        Console.WriteLine($"You have an {letter}");
    }
}