//if statement...
int age = 30;
if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}

Console.WriteLine("----------------");

//if else statement...
if (age >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}
Console.WriteLine("----------------");

//if else if statement...
int studentMarks = 30;
if (studentMarks >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (studentMarks >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (studentMarks >= 70)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: D");
}
Console.WriteLine("----------------");

//Nested if statement...
int personAge = 20;
bool hasCitizenship = false;
if (personAge >= 18)
{
    if (hasCitizenship)
    {
        Console.WriteLine("You are allowed to enter the club.");

    }
    else
    {
        Console.WriteLine("You need to have citizenship to enter the club.");
    }
}
else
{
    Console.WriteLine("You are not old enough to enter the club.");
}

Console.WriteLine("----------------");
//switch statement...
int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
}

Console.WriteLine("----------------");
//for loop...
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Count: {i}");
}

Console.WriteLine("----------------");
//while loop...
int count = 1;
while (count < 6)
{
    Console.WriteLine($"Count: {count}");
    count++;
}

Console.WriteLine("----------------");
//do while loop...
int number = 1;
do
{
    Console.WriteLine($"Number: {number}");
    number++;
} while (number < 6);

Console.WriteLine("----------------");
//foreach loop...
string[] names = ["Sugal", "Goku", "Anish", "Swornim"];
foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("----------------");
//break statement...
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine($"Count: {i}");
}

Console.WriteLine("----------------");
//continue statement...
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine($"Count: {i}");
}

//ternary operator...
int number1 = 10;
int number2 = 20;
string result = (number1 > number2) ? "Number1 is greater" : "Number2 is greater";
Console.WriteLine(result);