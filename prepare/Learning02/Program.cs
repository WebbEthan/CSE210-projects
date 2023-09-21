using System;

class Program
{

    static void Main(string[] args)
    {
        // Creates the job classes
        Job Job1 = new Job("Software Engineer", "Microsoft", "2019-2022");
        Job Job2 = new Job("Manager", "Apple", "2022-2023");

        // Creates the resume
        resume myResume = new resume("Ethan", new List<Job>() { Job1, Job2});
        myResume.Display();
    }
}