// Declare variables
string? name = string.Empty;
int age = 0;
int retiermentAge = 65;
decimal salary = 0;
char gender = char.MinValue;
bool working = true;

// Prompt the user for input
Console.Write("Please Enter your name:");
name = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Please enter your working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

// Process
int workingYearsRemaining = retiermentAge - age;
Console.WriteLine($"Full name: {name}");
Console.WriteLine($"Your Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"Your Are Employed: {working}");
Console.WriteLine($"Number of Working years that remaining: {workingYearsRemaining}");


