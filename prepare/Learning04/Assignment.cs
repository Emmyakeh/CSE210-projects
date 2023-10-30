public class Assignment

{
    private string StudentName1;
    private string Topic1;

    public Assignment(string StudentName, string Topic)
    {
        StudentName1 = StudentName;
        Topic1 = Topic;
    }
     public string GetStudentName()
    {
        return StudentName1;
    }

    public string GetTopic()
    {
        return Topic1;
    }

    public string GetSummary()
    {
        return StudentName1 + " - " + Topic1;
    }
}



