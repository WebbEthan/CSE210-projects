using System.Globalization;

public class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        // Constructs Data
        Prompts = new List<string> 
        {

        };
        Console.WriteLine("How Many Seconds Would You Like To Do This?");
        Durration = float.Parse(Console.ReadLine());
        // Runs Activity
        _run();
    }
    private List<string> _followUps = new List<string>()
    {

    };
    private void _run()
    {
        Console.Clear();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(2000);
        Random rd = new Random();
        while (Durration > 0)
        {
            Console.Clear();
            Console.WriteLine(Prompts[rd.Next(0, Prompts.Count - 1)]);
            GetResponse(out float ElapsedTime);
            LoadingBar(3);
            // TODO - Follow up questions
            Durration -= ElapsedTime + 3;
        }
        Console.Clear();
        Console.WriteLine("Keep doing these exersises more everyday to progress.");
        LoadingBar(3);
    }
}