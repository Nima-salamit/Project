Console.WriteLine("******* Lists *******");

// Standard
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
int gradeCount = 0;
string name = string.Empty;

// if the name of variable is keyword
int @continue;

var grades2 = new List<string>();

List<int> grades3 = new();

// Hard Code
// grades.Add(45);
// Console.WriteLine(grades[0]);

do
{
    gradeCount++;
    Console.WriteLine("Enter students name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.WriteLine("Enter grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if(grade != -1)
    {
        grades.Add(grade);
    }

    Console.WriteLine("Do you wish to continue? (1 = yes | 2 =No)");
    @continue = Convert.ToInt32(Console.ReadLine());

} while(@continue == 1);

Console.WriteLine("Printting grades: ");
for(int i = 0; i < gradeCount; i++)
{
    Console.WriteLine(grades[i]);
}

// foreach
// foreach(int g in grades)
// {
//     Console.WriteLine(g);
// }