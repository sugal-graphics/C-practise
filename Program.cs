public struct student


{
    public string FullName;
    public int Age;
    public string Address;
    public string EmailAddress;
    public int Semester;
    public string University;
    public long PhoneNumber;

    public student(string fullName, int age, string address, string emailAddress, int semester, string university, long phoneNumber)
    {
        FullName = fullName;
        Age = age;
        Address = address;
        EmailAddress = emailAddress;
        Semester = semester;
        University = university;
        PhoneNumber = phoneNumber;
    }
    public void Display()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("----------------");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Email Address: {EmailAddress}");
        Console.WriteLine($"Semester: {Semester}");
        Console.WriteLine($"University: {University}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine("----------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        student details = new student("Sugal", 19, "Dingarnagar, Tiltoama-4", "sugaldarlami@gmail.com", 2, "ISMT, UNIVERSITY OF SUNDERLAND", 9767022003);
        details.Display();

    }
}