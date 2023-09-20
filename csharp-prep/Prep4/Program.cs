using System;
using System.Globalization;

class Program
{
    static List<float> numbers = new List<float>();
    static void Main(string[] args)
    {
        // Gets a list of numbers from the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        float NewNumber = 1;
        while (NewNumber != 0)
        {
            Console.WriteLine("Enter Number:");
            if (float.TryParse(Console.ReadLine(), out NewNumber))
            {
                if (NewNumber != 0)
                {
                    numbers.Add(NewNumber);
                }
            }
            else
            {   
                Console.WriteLine("That was not a number you put in please enter a real number.");
            }
        }
        // Calculates and output
        float sum = 0;
        float largestNum = 0;
        float closestToZero = 0;
        List<float> sortedList = new List<float>();
        foreach (float value in numbers)
        {
            sum += value;
            if (value > largestNum)
            {
                // Finds the Larges Number
                largestNum = value;
            }
            if (value > 0 && (value < closestToZero || closestToZero == 0))
            {
                // Finds the positive number Closeset to Zero
                closestToZero = value;
            }
            // Sorting algorithm
            for (int index = 0; index <= sortedList.Count; index++)
            {
                if (index == sortedList.Count)
                {
                    sortedList.Add(value);
                    break;
                }
                else
                {
                    if (sortedList[index] > value)
                    {
                        sortedList.Insert(index, value);
                        break;
                    }
                }
            }
        }
        // Outputs the data to the user
        Console.WriteLine($"The sum is: {sum}");
        sum /= numbers.Count;
        Console.WriteLine($"The average is: {sum}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {closestToZero}");
        Console.WriteLine($"The sorted list is: {DisplayList(sortedList)}");        
    }
    /// Converts a list into a displayable string
    private static string DisplayList(List<float> numbers)
    {
        string display = "[";
        foreach (float number in numbers)
        {
            display += $"{number}, ";
        }
        display = display.Remove(display.Length-2, 2);
        display += ']';
        return display;
    }
}