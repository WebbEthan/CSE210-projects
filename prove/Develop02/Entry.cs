using Journal;

public class Entry
{
    // Used to Construct new Entrys
    public Entry(string _title, string _date, string _article)
    {
        Title = _title;
        Date = _date;
        Article = _article;
    }
    public string Title;
    public string Date;
    public string Article;
    // Starts the Editing of this journal entry
    public void Edit()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"({Date}) : {Title}");
        Article = Console.ReadLine();
    }
    // Displays the journal entry saved to this class
    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("--------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"({Date}) : {Title}");
        Console.WriteLine($"{Article}");
    }
}