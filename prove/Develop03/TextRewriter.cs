public static class TextRewriter
{
    // Removes words randomly
    public static string[] RemoveWords(ref string[] text, ref List<int> removable, int amount)
    {
        Random random = new Random();
        while (amount > 0 && removable.Count > 0)
        {
            int selectedWord = removable[random.Next(0, removable.Count()-1)];
            text[selectedWord] = new string('_', text[selectedWord].Length);
            removable.Remove(selectedWord);
            amount--;
        }
        return text;
    }
    // Formats the array of words into a single string
    public static string FormatOutput(string[] text)
    {
        string output = "";
        foreach(string word in text)
        {
            output += word + ' ';
        }
        return output;
    }
    // Formats the sentance into an array of words
    public static string[] FormatInput(string text)
    {
        string[] output = text.Split(' ');
        return output;
    }
}