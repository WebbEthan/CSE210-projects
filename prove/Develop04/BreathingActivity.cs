public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        // Constructs Data
        Console.Clear();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("How Many Seconds Would You Like To Do This - min 8 secs?");
        Durration = float.Parse(Console.ReadLine());
        // Runs Activity
        _run();
    }
    private void _run()
    {
        Console.Clear();
        float TempDurration = Durration;
        while (TempDurration > 0)
        {
            Console.Clear();
            Console.Write("\r Breath In \n");
            CountDown(4);
            Console.Clear();
            Console.Write("\r Breath Out \n");
            CountDown(4);
            TempDurration -= 8;
        }
        Console.Clear();
        Console.WriteLine("Well Done.");
        LoadingBar(3);
        Console.WriteLine($"You have completed {Durration}secs of breathing activitys.");
    }
}