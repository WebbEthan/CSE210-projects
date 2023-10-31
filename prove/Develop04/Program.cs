using System;
using System.Threading;
class Program
{
    private static Thread _main;
    static void Main(string[] args)
    {
        // Starts main thread;
        _main = new Thread(new ThreadStart(_mainThread));
        _main.Start();
    }
    private static void _mainThread()
    {
        while (true)
        {
            // Prompts user
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listening Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Enter Number.");
            // Creates Activity
            switch (Console.ReadLine())
            {
                case "1":
                    new BreathingActivity();
                    break;
                case "2":
                    new ReflectionActivity();
                    break;
                case "3":
                    new ListeningActivity();
                    break;
                case "4":
                    return;
            }
            Thread.Sleep(1000);
        }
    }
}