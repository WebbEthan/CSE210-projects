public static class FileManager
{
    public static void Save(List<Goal> goals, int points, string fileAddress)
    {
        // Assembles Data
        List<string> RawData = new List<string>();
        RawData.Add(points.ToString());
        foreach (Goal goal in goals)
        {
            RawData.Add(goal.SaveData);
        }
        // Writes the data to the file
        if (File.Exists(fileAddress))
        {
            File.WriteAllLines(fileAddress, RawData);
        }
        else
        {
            using (StreamWriter writer = File.CreateText(fileAddress))
            {
                foreach (string data in RawData)
                {
                    writer.WriteLine(data);
                }
            }
        }
    }
    public static bool Load(string fileAddress, out List<Goal> goals, out int points)
    {
        goals = new List<Goal>();
        if (File.Exists(fileAddress))
        {
            string[] save = File.ReadAllLines(fileAddress);
            points = int.Parse(save[0]);
            // Loads goals
            for (int i = 1; i < save.Length; i++)
            {
                // Parses line into datapoints
                string[] data = parseLine(save[i].Substring(1, save[i].Length - 1), ':');

                // Formats data into class
                switch (save[i][0])
                {
                    case '1':
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), data[3] == "1"));
                        break;
                    case '2':
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3])));
                        break;
                    case '3':
                        goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
                        break;
                }
            }
            return true;
        }
        points = 0;
        return false;
    }
    private static string[] parseLine(string line, char separater)
    {
        List<string> words = new List<string>();
        while (line.Length > 0)
        {
            if (line.Contains(separater))
            {
                words.Add(line.Substring(0, line.IndexOf(separater)));
                line = line.Remove(0, line.IndexOf(separater)+1);
            }
            else
            {
                words.Add(line);
                break;
            }
        }
        return words.ToArray();
    }
}