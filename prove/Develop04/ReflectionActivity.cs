using System.Globalization;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        // Constructs Data
        Console.Clear();
        Console.WriteLine("How Many Seconds Would You Like To Do This?");
        Durration = float.Parse(Console.ReadLine());
        // Runs Activity
        _run();
    }
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _followUps = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private void _run()
    {
        Console.Clear();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(2000);
        Random rd = new Random();
        //Main question
        Console.Clear();
        Console.WriteLine(_prompts[rd.Next(0, _prompts.Count - 1)]);
        Console.WriteLine("Please take a second to reflect");
        Console.WriteLine("-----------------------------------------------------------");
        while (Durration > 0)
        {
            LoadingBar(3);
            //Follow up questions
            Console.WriteLine("\r" + _followUps[rd.Next(0, _followUps.Count - 1)]);
            Console.WriteLine("Please write your response.");
            GetResponse(out float ElapsedTime);
            Durration -= ElapsedTime + 3;
        }
        Console.Clear();
        Console.WriteLine("Keep doing these exersises more everyday to progress.");
        LoadingBar(3);
    }
}