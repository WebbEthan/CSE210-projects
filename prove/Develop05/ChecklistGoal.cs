public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, string description, int points, int recordedTimes, int recordedGoal, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _recordedTimes = recordedTimes;
        _recordedGoal = recordedGoal;
        _bonus = bonus;
    }
    public ChecklistGoal()
    {
        Console.WriteLine("What do you want to name your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("Describe your goal...");
        _description = Console.ReadLine();
        Console.WriteLine("How many points should this goal be?");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times should this goal be acomplished?");
        _recordedGoal = int.Parse(Console.ReadLine());
        Console.WriteLine("What should the bonus be on full completion/");
        _bonus = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Goal added");
    }
    private int _bonus;
    private int _recordedGoal;
    private int _recordedTimes = 0;
    public override string SaveData { get{ return $"3{_name}:{_description}:{_points}:{_recordedTimes}:{_recordedGoal}:{_bonus}"; } }
    public override string Display { get{ return $"[{_recordedTimes}/{_recordedGoal}] {_name} ({_description}) - {_bonus} bonus points"; } }
    public override int Record()
    {
        if (_recordedTimes < _recordedGoal)
        {
            if (++_recordedTimes == _recordedGoal)
            {
                return _bonus + _points;
            }
            return _points;
        }
        return 0;
    }
}