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
            Console.Clear();
            Console.WriteLine("Press the up arrow to increase the difficulty, Press excape to return change the scripture.");
            Console.WriteLine(_scriptureReference);
            Console.WriteLine(TextRewriter.FormatOutput(_displayText));
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Escape:
                    return;
                case ConsoleKey.UpArrow:
                    TextRewriter.RemoveWords(ref _displayText, ref _shownWords, 3);
                    break;
                    
            }
        }
    }
}