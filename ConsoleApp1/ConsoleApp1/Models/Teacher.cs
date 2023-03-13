namespace ConsoleApp1.Models;

public class Teacher
{
    private static int _id = 0;

    public int Id { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }
    public int Salary { get; set; }

    //public Teacher()
    //{
    //    _id++;
    //    Id = _id;
    //}

    public static readonly string _test;

    static Teacher()
    {
        _test = "asdsadf";
        Console.WriteLine("salam");
    } 

    public static void Print(string text)
    {
        Console.WriteLine(_test);
        //Console.WriteLine(text);
    }
}