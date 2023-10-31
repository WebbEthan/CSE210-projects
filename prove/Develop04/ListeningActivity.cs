public class ListeningActivity : Activity
{
    public ListeningActivity()
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
    private void _run()
    {
        
    }
}