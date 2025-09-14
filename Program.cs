// Basic variable declarations and output in C#

int age = 25;
double pi = 3.14159;
string name = "Omri";
bool isStudent = true;
Console.WriteLine($"Name: {name}, Age: {age}, Pi: {pi}, Is Student: {isStudent}");

// Simple loop to print numbers from 1 to 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Conditional statement to check if age is greater than 18
switch (age)
{
    case > 18:
        Console.WriteLine("Old");
        break;
    default:
        Console.WriteLine("Young");
        break;
}

// Function to add two numbers
static int Add(int a, int b) => a + b;

int Main()
{
    int sum = Add(5, 10);
    Console.WriteLine($"Sum: {sum}");
    return 0;
}