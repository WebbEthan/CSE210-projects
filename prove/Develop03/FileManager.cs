using System.IO;
public static class FileManager
{
    // Extracts the scripture from the database
    public static string GetVerse(string verse)
    {
        IEnumerable<string> text = File.ReadLines(@"C:\Users\ethan\Desktop\CSE Homework\CSE210\CSE210-projects\prove\Develop03\lds-scriptures.txt").SkipWhile(line => !line.Contains(verse));
        string verseText = text.ToList()[0];
        verseText = verseText.Remove(0, verse.Length + 5);
        return verseText;
    }
}