public class MathAssignment : Assignment
{
    private float _section;
    private string _problems;
    public MathAssignment(string name, string type, float section, string problems)
    {
        _name = name;
        _type = type;
        _section = section;
        _problems = problems;
    }
    public void GetHomework() 
    {
        GetSummary();
        Console.WriteLine($"Section {_section} Problems {_problems}");
    }
}