using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Console.WriteLine(test1.ToString());
        Console.WriteLine(test1.GetDecimalValue.ToString());
        Fraction test2 = new Fraction(5);
        Console.WriteLine(test2.ToString());
        Console.WriteLine(test2.GetDecimalValue.ToString());
        Fraction test3 = new Fraction(3, 4);
        Console.WriteLine(test3.ToString());
        Console.WriteLine(test3.GetDecimalValue.ToString());
        Fraction test4 = new Fraction(1, 3);
        Console.WriteLine(test4.ToString());
        Console.WriteLine(test4.GetDecimalValue.ToString());
    }
}