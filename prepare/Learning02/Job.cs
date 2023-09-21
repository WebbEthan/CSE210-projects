public class Job
{
    public Job(string jobtitle, string company, string time)
    {
        _jobTitle = jobtitle;
        _company = company;
        _time = time;
    }
    public string _jobTitle;
    public string _company;
    public string _time;
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_time}");
    }
}
