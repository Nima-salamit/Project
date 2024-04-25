Console.WriteLine("****** Methods ******");

void printName()
{
    Console.WriteLine("Jany dep");
}

int getFiveYears()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}

int GetYearDifferencewithParams(int years)
{
    int yearDifference = DateTime.Now.Year - years;
    return yearDifference;
}

void printMyName(string name)
{
    Console.WriteLine(name);
}

// optional parameter
int GetFutureOnPastYears(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

printName();
int fiveyearsago = getFiveYears();
Console.WriteLine($"Five years ago was: {fiveyearsago}");

printMyName("Johny");
int diff = GetYearDifferencewithParams(2);
Console.WriteLine("Difference: " + diff);

var pastYear1 = GetFutureOnPastYears();
