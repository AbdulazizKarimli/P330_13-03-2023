namespace ConsoleApp1.Models;

public class Student
{
    private static int _id;

    public int Id { get; }
    public string Fullname { get; set; }
    public int Point { get; set; }

    public Student(string fullname, int point)
    {
        _id++;
        Id = _id;
        Fullname = fullname;
        Point = point;
    }

    public string StudentInfo()
    {
        return $"{Id} - {Fullname} - {Point}";
    }
}