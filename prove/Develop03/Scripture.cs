public class Scripture
{
    public Scripture(string scriptureReference, string[] text)
    {
        _scriptureReference = scriptureReference;
        _displayText = text;
        for (int i = 0; i < text.Length; i++)
        {
            _shownWords.Add(i);
        }
        Play();
    }
    private string _scriptureReference;
    private string[] _displayText;
    private List<int> _shownWords = new List<int>();
    public void Play()
    {
        while(true)
        {
            // Displays the scripture
            Console.Clear();
            Console.WriteLine("Press any key to increase the difficulty, Press excape to return change the scripture.");
            Console.WriteLine(_scriptureReference);
            Console.WriteLine(TextRewriter.FormatOutput(_displayText));

            // Handles the user input
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("Enter a scripture for example ( 1 Nephi 10:15 ), type notes to access your notes, or type quit to close the program.");
                    return;
                default:
                    TextRewriter.RemoveWords(ref _displayText, ref _shownWords, 3);
                    break;
                    
            }
        }
    }
}