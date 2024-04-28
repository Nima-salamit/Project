Console.WriteLine("**********  Arrays  **********");

Console.WriteLine("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];

// grades[0] = 15;
// grades[1] = 25;
// grades[2] = 35;
// grades[3] = 45;
// grades[4] = 55;

for (int i = 0; i < numberOfGrades; i++)
{
    //  Console.WriteLine($"grade {i} is: {grades[i]}");
    Console.WriteLine($"Please Student Name {i}");
    students[i] = Console.ReadLine();

    Console.WriteLine($"Please enter grade {i}");
    grades[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

Console.WriteLine("The grades that you entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
    // Console.WriteLine(students[i]);
    // Console.WriteLine($"grade {i} is: {grades[i]}");
}

Console.WriteLine();

string[] names = { "Newton", "Albert", "Jorj", "..." };

for (int i = 0; i < names.Length; i++)
{
    Console.Write($"Enter your name {i}: ");
    names[i] = Console.ReadLine();
}

Console.WriteLine("\n\nThe names that you entered are: \n");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"name {i} is: {names[i]}");
}


