using System;

public class Job
{
    public string _jobTitle;
    public int _salary;
    public string _companyName;

    public int _startYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_salary}-{_startYear}");
    }
}

