using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignment = new Assignment();
        Console.WriteLine(testAssignment.GetSummary());

        MathAssignment testMathAssignment = new MathAssignment();
        Console.WriteLine(testMathAssignment.GetSummary());
        Console.WriteLine(testMathAssignment.GetHomeworkList());

        WritingAssignment testWritingAssignment = new WritingAssignment();
        Console.WriteLine(testWritingAssignment.GetSummary());
        Console.WriteLine(testWritingAssignment.GetWritingInformation());
    }
}