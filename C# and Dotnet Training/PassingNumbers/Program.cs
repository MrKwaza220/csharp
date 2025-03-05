//Parsing numerical data from strings

using System.ComponentModel;

string[] NumStr = { "  1 ", " 1.45  ", "-100", "5e+04 " };

int testint;
float testfloat;
bool result;

//throws an exception if the parse unsuccessful
//foreach (string str in NumStr)
//{
//    try
//    {
//        testfloat = float.Parse(str);
//        Console.WriteLine($"Parsed number is {testfloat}");
//        testint = int.Parse(str);
//        Console.WriteLine($"Parsed number is {testint}");
//    }
//    catch (FormatException e)
//    {
//        Console.WriteLine($"Could not parse '{str}' : {e.Message}");
//    }
//}

// Using TryParse method returns 'true' if the parse is successful
result = int.TryParse(NumStr[0], out testint);
Console.WriteLine($"{result} -- '{NumStr[0]}' : {testint}");

result = float.TryParse(NumStr[1], out testfloat);
Console.WriteLine($"{result} -- '{NumStr[1]}' : {testfloat}");

result = int.TryParse(NumStr[2], out testint);
Console.WriteLine($"{result} -- '{NumStr[2]}' : {testint}");

result = float.TryParse(NumStr[3], out testfloat);
Console.WriteLine($"{result} -- '{NumStr[3]}' : {testfloat}");