using System.IO;
public static class FileManager
{
    // Extracts the scripture from the database
    public static bool GetVerse(string verse, out string verseContent)
    {
        IEnumerable<string> text = File.ReadLines(@"bin\Debug\net7.0\lds-scriptures.txt").SkipWhile(line => !line.Contains(verse));
        if (text.Count() > 0)
        {
            string verseText = text.ToList()[0];
            verseText = verseText.Remove(0, verse.Length + 5);
            verseContent = verseText;
            return true;
        }
        verseContent = "";
        return false;
    }
    public static void SaveNote(string note, string text)
    {
        if (File.Exists($@"bin\Debug\net7.0\Saves\{note}.txt"))
        {
            File.WriteAllLines($@"bin\Debug\net7.0\Saves\{note}.txt", new string[] {text});
        }
        else
        {
            using (StreamWriter writer = new StreamWriter ($@"bin\Debug\net7.0\Saves\{note}.txt"))
            {
                writer.WriteLine(text);
            }
        }
    }
    public static bool LoadNote(string note, out string text)
    {
        if (File.Exists($@"bin\Debug\net7.0\Saves\{note}.txt"))
        {
            text = File.ReadAllLines($@"bin\Debug\net7.0\Saves\{note}.txt")[0];
            return true;
        }
        text = "";
        return false;
    }
    public static string[] ListNotes()
    {
        if (Directory.Exists(@"bin\Debug\net7.0\Saves"))
        {
            string[] notes = Directory.GetFiles(@"bin\Debug\net7.0\Saves");
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = notes[i].Substring(23, notes[i].Length - 27);
            }
            return notes;
        }
        else
        {
            Directory.CreateDirectory(@"bin\Debug\net7.0\Saves");
            return new string[0];
        }
    }
}