Console.WriteLine("******** - DateTime manipulation - ********");
DateTime dateTime = new DateTime();

// Create a DateTime from date and time
var dateOfBirth = new DateTime(1980, 12, 25);
Console.WriteLine($"My Dob is: {dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1980, 12, 25, 14, 45, 25, DateTimeKind.Local);
Console.WriteLine($"My Dob is: {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of Week: {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of Year: {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick: {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

// current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now: " + now);