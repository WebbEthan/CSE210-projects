public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // Constructs Data
        Prompts = new List<string> 
        {

        };
        Console.Clear();
        Console.WriteLine("How Many Seconds Would You Like To Do This - min 8 secs?");
        Durration = float.Parse(Console.ReadLine());
        // Runs Activity
        _run();
    }
    private void _run()
    {
        Console.Clear();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Thread.Sleep(2000);
        while (Durration > 0)
        {
            Console.Clear();
            Console.Write("\r Breath In \n");
            CountDown(4);
            Console.Clear();
            Console.Write("\r Breath Out \n");
            CountDown(4);
            Durration -= 8;
        }
        Console.Clear();
        Console.WriteLine("Keep doing these exersises more everyday to progress.");
        LoadingBar(3);
    }
}