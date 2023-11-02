public class Activity
{
    protected float Durration;
    public static void LoadingBar(float Time)
    {
        while (Time > 0)
        {
            Console.Write("\r .  ");
            Thread.Sleep(333);
            Console.Write("\r .. ");
            Thread.Sleep(333);
            Console.Write("\r ...");
            Thread.Sleep(334);
            Time--;
        }
    }
    public static void CountDown(float Time)
    {
        while (Time > 0)
        {
            Console.Write($"\r {Time}  ");
            Thread.Sleep(1000);
            Time--;
        }
    }
    protected static string GetResponse(out float ElapsedResponseTime)
    {
        DateTime current = DateTime.Now;
        string response = Console.ReadLine();

        ElapsedResponseTime = (float)DateTime.Now.Subtract(current).TotalSeconds;
        return response;
    }
}