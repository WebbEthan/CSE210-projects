using Journal;

public class Entry
{
    public string Title;
    public string Date;
    public string Article;
    public Entry(string _title, string _date, string _article)
    {
        Title = _title;
        Date = _date;
        Article = _article;
    }
    public void Edit()
    {
        Console.WriteLine($"({Date}) : {Title}");
        Article = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine($"({Date}) : {Title}");
        Console.WriteLine($"{Article}");
    }
}