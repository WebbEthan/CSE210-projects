namespace Journal
{
    class Program
    {
        // Posible prompts for new entrys
        private static string[] Prompts =  new string[]{
            "What could I have done better today?",
            "What did I enjoy the most today?",
            "What can I pray about today?",
            "How am I feeling?",
            "What do I plan on doing now that today is over?"
        };
        // This is the Entry currenty displayed
        private static List<Entry> CurrentEntrys = new List<Entry>();
        static void Main(string[] args)
        {
            while (true)
            {   

                Console.WriteLine("Please select what you would like to do.");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Enter Number Or Keyword...");

                // Parses the input into various actions
                switch(Console.ReadLine().ToLower())
                {
                    case "1":
                        NewEntry();
                        break;
                    case "write":
                        NewEntry();
                        break;
                    case "2":
                        // Runs display in each Entry stored in Current Entrys
                        foreach (Entry entry in CurrentEntrys)
                        {
                            entry.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "display":
                        // Runs display in each Entry stored in Current Entrys
                        foreach (Entry entry in CurrentEntrys)
                        {
                            entry.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        if (FileManager.LoadFile(out List<Entry> data)) { CurrentEntrys = data; }
                        break;
                    case "load":
                        if (FileManager.LoadFile(out List<Entry> data2)) { CurrentEntrys = data2; }
                        break;
                    case "4":
                        FileManager.SaveFile(CurrentEntrys);
                        break;
                    case "save":
                        FileManager.SaveFile(CurrentEntrys);
                        break;
                    case "5":
                        return;
                    case "quit":
                        return;         
                }
            }

        }
        private static void NewEntry()
        {
            // Creates a new Entry
            Random random = new Random();
            Entry writen = new Entry(Prompts[random.Next(0, Prompts.Length-1)], DateTime.Now.Date.ToString(), null);

            // Opens the Editor
            writen.Edit();
            CurrentEntrys.Add(writen);
        }
    }
}