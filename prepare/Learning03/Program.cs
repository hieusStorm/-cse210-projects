using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(5);
        Fraction test3 = new Fraction(5, 3);

        Console.WriteLine(test1.GetFactionString());

        test2.SetDenominator(6);
        
        Console.WriteLine(test2.GetDenominator());

        test3.SetNumerator(1);

        Console.WriteLine(test3.GetNumerator());

        Console.WriteLine($"{test1.GetDecimalValue()} {test2.GetFactionString()} {test2.GetDecimalValue()} {test3.GetFactionString()} {test3.GetDecimalValue()}");
    }
}