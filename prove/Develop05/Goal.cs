public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    // Gets the string it should have when saving that data
    public abstract string SaveData {get;}
    // Gets the string it should diplay when calling display
    public abstract string Display {get;}
    // Increaments the progress on the goal
    public abstract int Record();
}