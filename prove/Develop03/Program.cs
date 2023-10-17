class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a scripture for example ( 1 Nephi 10:15 ), or type quit to close the program");
            string address = Console.ReadLine();
            if (address == "quit")
            {
                return;
            }
            OpenScripture(address);
        }
    }
    private static void OpenScripture(string verse)
    {
        // Gets scripture from the FileManager
        string text = FileManager.GetVerse(verse);
        // Runs the scripture memorizer
        new Scripture(verse, TextRewriter.FormatInput(text));
    }
}