namespace Journal
{
    using System.IO;
    public static class FileManager
    {
        public const string DefaultFileAddress = @"C:\Users\ethan\Desktop\CSE Homework\CSE210\CSE210-projects\prove\Develop02\JournalEntrys\entry.txt";
        public static void SaveFile(List<Entry> entrys)
        {
            if (entrys != null && entrys.Count > 0)
            {
                // assembles data to save
                string[] lines = new string[entrys.Count * 3];
                for (int i = 0, entry = 0; entry < entrys.Count; i +=3, entry++)
                {
                    lines[i] = entrys[entry].Title;
                    lines[i + 1] = entrys[entry].Date;
                    lines[i + 2] = entrys[entry].Article;
                }
                File.WriteAllLines(DefaultFileAddress, lines);
                Console.WriteLine("Succesfully Saved");
            }
            else
            {
                Console.WriteLine("Please write something before saving.");
            }
        }
        public static bool LoadFile(out List<Entry> data)
        {
            if (File.Exists(DefaultFileAddress))
            {
                data = new List<Entry>();
                // Gets File Text
                string[] FileData = File.ReadAllLines(DefaultFileAddress);
                for (int i = 0; i < FileData.Length; i += 3)
                {
                    string _title = FileData[i];
                    string _date = FileData[i + 1];
                    string _article = FileData[i + 2];
                    data.Add(new Entry(_title, _date, _article));
                }
                return true;
            }
            else
            {
                data = null;
                return false;
            }
        }
    }
}