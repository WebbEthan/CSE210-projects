using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int FavoriteNumber = PromptUserNumber();
        DisplayResult(name, SquareNumber(FavoriteNumber));
    }
    private static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    private static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        return Console.ReadLine();
    }
    private static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        return int.Parse(Console.ReadLine());
    }
    private static int SquareNumber(int number)
    {
        return number * number;
    }
    private static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}