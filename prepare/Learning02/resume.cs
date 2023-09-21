public class resume
{
    public resume(string name, List<Job> Jobs)
    {  
        _name = name;
        _Jobs = Jobs;
    }
    public string _name;
    public List<Job> _Jobs;
    public void Display()
    {
        Console.WriteLine($"name: {_name}");
        // Displays Job info
        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }
}