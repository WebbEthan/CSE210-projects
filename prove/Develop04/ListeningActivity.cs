public class ListeningActivity : Activity
{
    public ListeningActivity()
    {
        // Constructs Data
        Console.Clear();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("How Many Seconds Would You Like To Do This?");
        Durration = float.Parse(Console.ReadLine());
        // Runs Activity
        _run();
    }
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<List<string>> _responses = new List<List<string>>();
    private void _run()
    {
        Console.Clear();
        Random rd = new Random();
        int ResponseCount = 0;
        //Questions
        while (Durration > 0)
        {
            //Prompt
            Console.Clear();
            string prompt = _prompts[rd.Next(0, _prompts.Count - 1)];
            Console.WriteLine(prompt);
            Console.WriteLine("Please take a second to reflect and write as many responses as you can for 10 seconds");
            List<string> response = new List<string>(){ prompt };
            //Responses
            float totalResponseTime = 0;
            while (totalResponseTime < 10)
            {
                response.Add(GetResponse(out float responseTime));
                totalResponseTime += responseTime;
                ResponseCount++;
            }
            _responses.Add(response);
            Durration-=10;
        }
        //Display responses
        Console.WriteLine($"\nTotal of {ResponseCount} responses");
        Thread.Sleep(1000);
        foreach (List<string> response in _responses)
        {
            Console.WriteLine($"\n{response[0]}");
            for(int i = 1; i < response.Count; i++)
            {
                Console.WriteLine($"{i}. {response[i]}");
            }
        }
        LoadingBar(6);
        //Close activity
        Console.Clear();
        Console.WriteLine("Well Done.");
        LoadingBar(3);
    }
}