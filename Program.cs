// Declare variables
string name = string.Empty;
int age = 0;
int retiermentAge = 65;

// Prompt the user for input
Console.WriteLine("Please Enter your name:");
name = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process
int workingYearsRemaining = retiermentAge - age;
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Your Age: {age}");
Console.WriteLine($"Working years that remaining: {workingYearsRemaining}");


