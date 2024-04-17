Console.WriteLine("Please enter student's grade:");
int grade = Convert.ToInt32(Console.ReadLine());

if(grade > 50)
{
    Console.WriteLine("Student has passed");
} 
else
{
    Console.WriteLine("Student has failed.");
}

Console.WriteLine("Thanks for using our app");