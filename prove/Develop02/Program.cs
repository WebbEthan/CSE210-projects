namespace Journal
{
    static class Program
    {
        public static int PreviousPrompt = 0;
        public static List<string> Prompts =  new List<string>() {
            "No Prompt Found!"
        };
        // This is the Entry currenty displayed
        private static List<Entry> CurrentEntrys = new List<Entry>();
        static void Main(string[] args)
        {
            // loads the save file and the saved prompts
            if (FileManager.LoadFile(out List<string> promptsdata, out List<Entry> data)) { Prompts = promptsdata; CurrentEntrys = data; }
            while (true)
            {   

                Console.WriteLine("Please select what you would like to do.");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Delete Save File");
                Console.WriteLine("6. Change Prompts");
                Console.WriteLine("7. Quit");
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
                        if (FileManager.LoadFile(out List<string> promptsdata2, out List<Entry> data2)) { Prompts = promptsdata2; CurrentEntrys = data2; }
                        break;
                    case "load":
                        if (FileManager.LoadFile(out List<string> promptsdata3 ,out List<Entry> data3)) { Prompts = promptsdata3; CurrentEntrys = data3; }
                        break;
                    case "4":
                        FileManager.SaveFile(CurrentEntrys);
                        break;
                    case "save":
                        FileManager.SaveFile(CurrentEntrys);
                        break;
                    case "5":
                        CurrentEntrys.Clear();
                        break;
                    case "delete":
                        CurrentEntrys.Clear();
                        break;
                    case "6":
                        ModifyPrompts();
                        break;
                    case "prompt":
                        ModifyPrompts();
                        break;
                    case "7":
                        return;
                    case "quit":
                        return;         
                }
            }

        }
        private static void ModifyPrompts()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            string response = Console.ReadLine();
            if (response == "1" || response == "Add")
            {
                // Adds a new prompt
                Console.WriteLine("Enter New Prompt");
                Prompts.Add(Console.ReadLine());
                Console.WriteLine("Prompt Added");
            }
            else if (response == "2" || response == "Remove")
            {
                // List the prompts for the user
                for (int i = 0; i < Prompts.Count; i++)
                {
                    Console.WriteLine($"{i}. {Prompts[i]}");
                }
                // Deletes the prompt with the users input gives a response if they input the number wrong or if it is deleted
                Console.WriteLine("Please input the number of the prompt you wish to delete.");
                if (int.TryParse(Console.ReadLine(), out int DeletedPrompt))
                {
                    if (DeletedPrompt > -1 && DeletedPrompt < Prompts.Count)
                    {
                        Prompts.RemoveAt(DeletedPrompt);
                        Console.WriteLine("Prompt Deleted");
                    }
                    else
                    {
                        Console.WriteLine($"That is not a number");
                    }
                }
                else
                {
                    Console.WriteLine($"That is not a number");
                }
            }
        }
        private static void NewEntry()
        {
            if (++PreviousPrompt >= Prompts.Count)
            {
                PreviousPrompt = 0;
            }
            // Creates a new Entry
            Entry writen = new Entry(Prompts[PreviousPrompt], DateTime.Now.Date.ToString(), null);

            // Opens the Editor
            writen.Edit();
            CurrentEntrys.Add(writen);
        }
    }
}