using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating Job objects
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Instantiating Resume object
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1._jobs = [job1, job2];

        // Calling Display functions
        resume1.Display();
    }
}