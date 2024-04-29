Console.WriteLine("******* - Classes and Objects - *******");

// Define an object of Type Person
Person baby = new Person(); // initialized
Person person; // null by default - not initialize

baby.LastName = "Jaked";
baby.FirstName = "Petter";
baby.DateOfBirth = new DateOnly(2050, 12, 12);

Console.WriteLine($"{baby.FirstName} {baby.LastName}");
Console.WriteLine("*******************");
baby.PrintFullName();
Console.WriteLine("*******************");
baby.PrintInitial();
Console.WriteLine("*******************");
baby.GenerateTaxNumber();
Console.WriteLine("*******************");
var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);

var person1  = new Person("John", "Yapson", new DateOnly(2000, 11, 2));
person1.PrintFullName();
person1.PrintInitial();


