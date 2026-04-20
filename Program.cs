public struct student
{
    public string FullName;
    public int Age;
    public string Address;
    public string EmailAddress;
    public int Semester;
    public string University;
    public long PhoneNumber;

}
class Program
{
    static void Main(string[] args)
    {
        student Details;
        Details.FullName = "Sugal Darlami";
        Details.Age = 19;
        Details.Address = "Dingarnagar, Tiltoama-4";
        Details.EmailAddress = "sugaldarlami@gmail.com";
        Details.Semester = 2;
        Details.University = "ISMT, UNIVERSITY OF SUNDERLAND";
        Details.PhoneNumber = 9767022003;
        Console.WriteLine("Student Details:");
        Console.WriteLine("----------------");
        Console.WriteLine($"Full Name: {Details.FullName}");
        Console.WriteLine($"Age: {Details.Age}");
        Console.WriteLine($"Address: {Details.Address}");
        Console.WriteLine($"Email Address: {Details.EmailAddress}");
        Console.WriteLine($"Semester: {Details.Semester}");
        Console.WriteLine($"University: {Details.University}");
        Console.WriteLine($"Phone Number: {Details.PhoneNumber}");
        Console.WriteLine("----------------");
    }
}