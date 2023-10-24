public class EnglishAssignment : Assignment
{
    private string _title;
    public EnglishAssignment(string name, string type, string title)
    {
        _name = name;
        _type = type;
        _title = title;
    }
    public void GetHomework()
    {
        GetSummary();
        Console.WriteLine(_title);
    }
}