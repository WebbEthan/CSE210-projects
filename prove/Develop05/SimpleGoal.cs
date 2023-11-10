public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = complete;
    }
    public SimpleGoal()
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
    private bool _complete = false;
    public override string SaveData { get{ return $"1{_name}:{_description}:{_points}:{Convert.ToByte(_complete)}"; } }
    public override string Display { get{ if (_complete) { return $"[X] {_name} ({_description})"; } else { return $"[ ] {_name} ({_description})"; }} }
    public override int Record()
    {
        if (!_complete)
        {
            _complete = true;
            return _points;
        }
        return 0;
    }
}