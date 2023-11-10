public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, int recordedTimes)
    {
        _name = name;
        _description = description;
        _points = points;
        _recordedTimes = recordedTimes;
    }
    public EternalGoal()
    {
        Console.WriteLine("What do you want to name your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("Describe your goal...");
        _description = Console.ReadLine();
        Console.WriteLine("How many points should this goal be?");
        _points = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Goal added");
    }
    private int _recordedTimes = 0;
    public override string SaveData { get{ return $"2{_name}:{_description}:{_points}:{_recordedTimes}"; } }
    public override string Display { get{ return $"[{_recordedTimes}] {_name} ({_description})"; } }
    public override int Record()
    {
        _recordedTimes++;
        return _points;
    }
}