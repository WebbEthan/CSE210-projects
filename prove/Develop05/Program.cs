using System;

class Program
{
    private static int _points;
    private static List<Goal> _goals = new List<Goal>();
    static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine($"Points : {_points}\n\n" + 
            "Please choose an option...\n" +
            "1. Create a new goal\n" +
            "2. Save\n" +
            "3. Load\n" +
            "4. Display goals\n" +
            "5. Record event\n" +
            "6. Quit");
            switch(Console.ReadLine())
            {
                case "1": // Create New Goal
                    Console.WriteLine("What type of goal do you want to create?\n" +
                    "1. Simple goal\n" +
                    "2. Eternal goal\n" +
                    "3. Checklist goal");
                    switch(Console.ReadLine())
                    {
                        case "1":
                            _goals.Add(new SimpleGoal());
                            break;
                        case "2":
                            _goals.Add(new EternalGoal());
                            break;
                        case "3":
                            _goals.Add(new ChecklistGoal());
                            break;
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                case "2": // Save File
                    Console.WriteLine("Please input the file name to save to...");
                    FileManager.Save(_goals, _points, Console.ReadLine());
                    Console.WriteLine("Data saved");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                case "3": // Load File
                    Console.WriteLine("Please input the file name to load from...");
                    if (FileManager.Load(Console.ReadLine(), out _goals, out _points))
                    {
                        Console.WriteLine("Data loaded");
                    }
                    else
                    {
                        Console.WriteLine("File not found");
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
                case "4": // Display Goals
                    Display();
                    break;
                case "5": // Record Progress
                    Display();
                    Console.WriteLine("What goal did you acomplish?");
                    int pointsEarned = _goals[int.Parse(Console.ReadLine())].Record();
                    Console.WriteLine($"You earned {pointsEarned}");
                    _points += pointsEarned;
                    Thread.Sleep(2000);
                    break;
                case "6": // Quit
                    return;
            }
        }
    }
    private static void Display()
    {
        Console.Clear();
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].Display}");
        }
    }
}