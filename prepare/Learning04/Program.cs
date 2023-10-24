using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new("Bob", "Quantum", 82.4f, "1-20");
        EnglishAssignment english = new("Jeff", "3088 Conflicts", "The Invention of time travel.");

        math.GetHomework();
        english.GetHomework();
    }
}