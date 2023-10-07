/*
    * This is a simple Journaling program that prompts the user to write in there journal
        it allows the user to add and remove Journal prompts that are used when they start a new entry
        the prompts and the entrys are then saved to a text file

    * The save file is loaded when the program starts automatically or can be loaded manually by the user
    * the save file also contains all the prompts that the user has.

    * The user can also display all the Journal entrys

    * The program also uses color cordination to make it as easy as prosible for the user to understand what is
        happening without leaving a console or creating a renderer
*/
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
                // Displays options
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("-----------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Writing in your jounal is a good activity you can do this.");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Delete Save File");
                Console.WriteLine("6. Change Prompts");
                Console.WriteLine("7. Quit");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter Number Or Keyword...");
                Console.ForegroundColor = ConsoleColor.White;

                // Parses the input into various actions
                switch(Console.ReadLine().ToLower())
                {
                    case "1":
                        // Starts a new Journal Entry
                        NewEntry();
                        break;
                    case "write":
                        // Starts a new Journal Entry
                        NewEntry();
                        break;
                    case "2":
                        // Runs display in each Entry stored in Current Entrys
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("-----------------------------------------");
                        foreach (Entry entry in CurrentEntrys)
                        {
                            entry.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "display":
                        // Runs display in each Entry stored in Current Entrys
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("-----------------------------------------");
                        foreach (Entry entry in CurrentEntrys)
                        {
                            entry.Display();
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        // Loads the saved File
                        if (FileManager.LoadFile(out List<string> promptsdata2, out List<Entry> data2)) { Prompts = promptsdata2; CurrentEntrys = data2; }
                        break;
                    case "load":
                        // Loads the saved File
                        if (FileManager.LoadFile(out List<string> promptsdata3 ,out List<Entry> data3)) { Prompts = promptsdata3; CurrentEntrys = data3; }
                        break;
                    case "4":
                        FileManager.SaveFile(CurrentEntrys);
                        break;
                    case "save":
                        FileManager.SaveFile(CurrentEntrys);
                        break;
                    case "5":
                        // Deletes all entrys loaded
                        CurrentEntrys.Clear();
                        break;
                    case "delete":
                        // Deletes all entrys loaded
                        CurrentEntrys.Clear();
                        break;
                    case "6":
                        // Allows the adding and deleteing of journal prompts
                        ModifyPrompts();
                        break;
                    case "prompt":
                        // Allows the adding and deleteing of journal prompts
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
            // Prompts the user their options to add or delete a prompt
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter Number");

            Console.ForegroundColor = ConsoleColor.White;
            string response = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (response == "1" || response == "Add")
            {
                // Adds a new prompt
                Console.WriteLine("Enter New Prompt");
                Console.ForegroundColor = ConsoleColor.White;
                Prompts.Add(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
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
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Prompt Deleted");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"That is not a number");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
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