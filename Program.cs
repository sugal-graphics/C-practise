public struct student
{
    public string name;
    public int age;
}
class Program
{
    static void Main(string[] args)
    {
        student s1;
        s1.name = "John";
        s1.age = 20;
        Console.WriteLine(s1.name);
    }
}