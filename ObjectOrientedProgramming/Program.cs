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

var teacher = new Teacher();
teacher.FirstName = "Messi";
teacher.LastName = "Masive";
teacher.PrintFullName();
teacher.GenerateTeacherIdNumber();
var teacherIdNumber = teacher.GetIdNUmber();
Console.WriteLine(teacherIdNumber);

var student = new Student();
student.FirstName = "Ronaldo";
student.LastName = "tan";
student.PrintFullName();
student.GenerateStudentIdNumber();
var studentIdNumber = student.GetIdNUmber();
Console.WriteLine(studentIdNumber);


Rectangle rectangle = new(10, 20);
var rectangleArea = rectangle.Area();

Square square = new(50);
var squareArea = square.Area();