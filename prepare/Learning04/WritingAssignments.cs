public class WritingAssignment : Assignment
{
    private string _title;

    // constructor
    public WritingAssignment(string studentName, string topic, string _title) : base(studentName, topic)
    {
        _title = _title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}