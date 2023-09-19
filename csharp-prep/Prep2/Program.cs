using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Grade Percentage...");
        float Grade = float.Parse(Console.ReadLine());
        string LetterGrade = "F";
        if (Grade >= 90)
        {
            LetterGrade = "A";
        }
        else if (Grade >= 80)
        {
            LetterGrade = "B";
        }
        else if (Grade >= 70)
        {
            LetterGrade = "C";
        }
        else if (Grade >= 60)
        {
            LetterGrade = "D";
        }
        if (LetterGrade != "F")
        {
            float GradeLevel = Grade % 10;
            if (GradeLevel >= 7 && LetterGrade != "A")
            {
                LetterGrade += '+';
            }
            else if (GradeLevel < 3 && Grade < 100)
            {
                LetterGrade += '-';
            }
        }
        Console.WriteLine($"You got a {LetterGrade}");
        if (Grade >= 70)
        {
            Console.WriteLine("Yay you passed!");
        }
        else
        {
            Console.WriteLine("You failed :( Don't give up though you will get it next time");
        }
    }
}