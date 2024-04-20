int age  = 0;

try
{
    Console.WriteLine("Please enter your age: ");
    age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your age is {age} years old.");
}
catch (Exception)
{
    Console.Clear();
    Console.WriteLine("\nPlease enter number, format string is not acceptable.\n\n");
    //throw;
}
finally
{
    Console.WriteLine("Please enter another number: ");
    Console.ReadLine();
}
switch (age)
{
    case 0:
        Console.WriteLine($"Your age is {age}!!!");
        break;
    default:
        throw new Exception("Please enter numerical input.");
}