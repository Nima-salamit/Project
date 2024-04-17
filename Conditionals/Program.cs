Console.WriteLine("Please enter student's grade:");
int grade = Convert.ToInt32(Console.ReadLine());

if(grade < 50)
{
    Console.WriteLine("Student has Faild!!!");
} else if (grade >= 50 && grade < 70)
{
    Console.WriteLine("Student grade is >> C");
} else if(grade >= 70 && grade < 90)
{
    Console.WriteLine("Student grade is >> B");
} else if (grade >= 90 && grade <= 100)
{
    Console.WriteLine("Student grade is >> A");
}
else
{
    Console.WriteLine("Student has failed.");
}

string passStatus = grade < 50 ? "Fail" : "Pass";
Console.WriteLine("Status: " + passStatus);
Console.WriteLine("Thanks for using our app");