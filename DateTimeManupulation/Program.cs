Console.WriteLine("********** - String Manipulation - **********");

string s1 = "This is literal string";
String s2 = "This is literal string";
Console.WriteLine($"{nameof(s1)} : {s1}");
Console.WriteLine($"{nameof(s2)} : {s2}");

string s3;

string? s4 = null;
Console.WriteLine($"{nameof(s4)} : {s4}");

string s5 = string.Empty;
string s6 = "";
Console.WriteLine($"{nameof(s5)} : {s5}");
Console.WriteLine($"{nameof(s6)} : {s6}");

string sentence = "She said, \" I have your phone \" \r\n This is a next line";
Console.WriteLine($"{nameof(sentence)} : {sentence}");

string oldPath = "C:\\program\\users\\";

s1 = s1 + s2;
s1 += s2;

string newString = $"{s1} {s2} are some random literals";
string newString1 = s1 + $"{s1} {s2} some random literals.";
string newString2 = string.Format("Literals string {0} {1} ", s1, s2);

Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");

// if(string.IsNullOrEmpty(s4) == false)
if(!string.IsNullOrEmpty(s4))
{
   Console.WriteLine($"{nameof(s6)} has a length of {s4.Length}"); 
}


string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s1.Substring(5, 5);

var splitString = s2.Split(' ');
for(int i = 0; i < splitString.Length; i++){
    Console.WriteLine(splitString[i]);
}

string replacement1 = s1.Replace('s' , 'V');
Console.WriteLine($"{nameof(replacement1)} : {replacement1}");

string replacement2 = s1.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacement2)} : {replacement2}");

string salary = 42000.ToString();
int value = 2300;
string strValue = value.ToString();

Console.WriteLine($"{nameof(salary)} : {salary}");



