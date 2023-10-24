public class Assignment
{
    protected string _name;
    protected string _type;
    public void GetSummary()
    {
        Console.WriteLine($"{_name} - {_type}");
    }
}