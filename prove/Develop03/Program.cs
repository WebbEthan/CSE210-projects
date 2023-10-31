class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter a scripture for example ( 1 Nephi 10:15 ), type notes to access your notes, or type quit to close the program.");
        while (true)
        {
            string address = Console.ReadLine();
            switch (address)
            {
                case "notes":
                    string note = "";
                    while (note != "back")
                    {
                        string[] notes = FileManager.ListNotes();
                        Console.Clear();
                        foreach(string noteName in notes)
                        {
                            Console.WriteLine(noteName);
                        }
                        Console.WriteLine("Enter note title to access note, type new to create a new note, or type back nothing to to back.");
                        note = Console.ReadLine();
                        switch (note)
                        {
                            case "new":
                                Console.Clear();
                                Console.WriteLine("Enter note name.");
                                string noteName = Console.ReadLine();
                                Console.WriteLine("Enter note text.");
                                string noteText = Console.ReadLine();
                                FileManager.SaveNote(noteName, noteText);
                                break;
                            case "back":
                                break;
                            default:
                                if (FileManager.LoadNote(note, out string text))
                                {
                                    new Scripture(note, TextRewriter.FormatInput(text));
                                }
                                else
                                {
                                    Console.WriteLine("Note not found");
                                }
                                break;
                        }
                    }
                    break;
                case "quit":
                    return;
                default:
                    OpenScripture(address);
                    break;
            }
        }
    }
    private static void OpenScripture(string verse)
    {
        // Gets scripture from the FileManager
        if (FileManager.GetVerse(verse, out string text))
        {
            // Runs the scripture memorizer
            new Scripture(verse, TextRewriter.FormatInput(text));
        }
        else
        {
            Console.WriteLine("Scripture reference not found.");
        }
    }
}