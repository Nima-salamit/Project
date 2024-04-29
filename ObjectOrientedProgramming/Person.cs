using System.Security.Cryptography;

public class Person
{

    public Person()
    {

    }

    public Person(string firstName, string lastName, DateOnly dob)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }

    // ctor
    public Person(string firstName, string lastName, string taxnumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxtNumber = taxnumber;
    }
    // Properties / Data members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field
    private string _taxtNumber;
    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitial()
    {
        var firstInitial = FirstName[0];
        var lastInitial = LastName[0];
        Console.WriteLine($"{firstInitial} {lastInitial}");
    }

    public void GenerateTaxNumber()
    {
        if (string.IsNullOrEmpty(_taxtNumber))
        {
            _taxtNumber = RandomNumberGenerator.GetInt32(10000, 999999).ToString();
        }
    }

    public string GetTaxNumber()
    {
        return _taxtNumber;
    }

    public int GetAge()
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

// Method Overloading
    public int GetAge(int year)
    {
        var age = year - DateOfBirth.Year;
        return age;
    }
}



