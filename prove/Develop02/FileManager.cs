namespace Journal
{
    using System.IO;
    public static class FileManager
    {
        public const string DefaultFileAddress = @"C:\Users\ethan\Desktop\CSE Homework\CSE210\CSE210-projects\prove\Develop02\JournalEntrys\entry.txt";
        public static void SaveFile(List<Entry> entrys)
        {
            // Initializes data to save
            int lineIndex = lineIndex = Program.Prompts.Count + 2;;
            string[] lines = new string[entrys.Count * 3 + Program.Prompts.Count + 2];
            lines[0] = Program.Prompts.Count.ToString();
            lines[1] = Program.PreviousPrompt.ToString();
            // Assembles the prompts
            for (int prompt = 0; prompt < Program.Prompts.Count; prompt++)
            {
                lines[prompt + 2] = Program.Prompts[prompt];
            }
            // Assembles the Entry data
            for (int i = 0, entry = 0; entry < entrys.Count; i +=3, entry++)
            {
                lines[i + lineIndex] = entrys[entry].Title;
                lines[i + 1 + lineIndex] = entrys[entry].Date;
                lines[i + 2 + lineIndex] = entrys[entry].Article;
            }

            // Writes assembled data to the file
            File.WriteAllLines(DefaultFileAddress, lines);
            Console.WriteLine("Succesfully Saved");
        }
        public static bool LoadFile(out List<string> prompts, out List<Entry> data)
        {
            if (File.Exists(DefaultFileAddress))
            {
                data = new List<Entry>();
                // Gets File Text
                string[] FileData = File.ReadAllLines(DefaultFileAddress);
                // Reads the prompts
                int promptCount = int.Parse(FileData[0]);
                Program.PreviousPrompt = int.Parse(FileData[1]);
                prompts = new List<string>();
                for (int i = 0; i < promptCount; i++)
                {
                    prompts.Add(FileData[i + 2]);
                }
                // Reads the Entry datas
                for (int i = 0; i < FileData.Length - promptCount - 2; i += 3)
                {
                    string _title = FileData[i + promptCount + 2];
                    string _date = FileData[i + 1 + promptCount + 2];
                    string _article = FileData[i + 2 + promptCount + 2];
                    // Assembles the data in an Entry class and adds it to the returned list
                    data.Add(new Entry(_title, _date, _article));
                }
                return true;
            }
            else
            {
                prompts = null;
                data = null;
                return false;
            }
        }
    }
}