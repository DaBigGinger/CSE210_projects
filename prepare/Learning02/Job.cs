// Create Job class

using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

// Display Method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
    


