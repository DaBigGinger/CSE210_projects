public class Assignment
{
    // Member variables
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // Method to return summary of the assignment
    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }
}