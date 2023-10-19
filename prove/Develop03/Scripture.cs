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
                    return;
                default:
                    TextRewriter.RemoveWords(ref _displayText, ref _shownWords, 3);
                    break;
                    
            }
        }
    }
}