//Parsing numerical data from strings

//using System.ComponentModel;

//string[] NumStr = { "  1 ", " 1.45  ", "-100", "5e+04 " };

//int testint;
//float testfloat;
//bool result;

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
//result = int.TryParse(NumStr[0], out testint);
//Console.WriteLine($"{result} -- '{NumStr[0]}' : {testint}");

//result = float.TryParse(NumStr[1], out testfloat);
//Console.WriteLine($"{result} -- '{NumStr[1]}' : {testfloat}");

//result = int.TryParse(NumStr[2], out testint);
//Console.WriteLine($"{result} -- '{NumStr[2]}' : {testint}");

//result = float.TryParse(NumStr[3], out testfloat);
//Console.WriteLine($"{result} -- '{NumStr[3]}' : {testfloat}");


// Numeric Formatting in C#

int number = 12345;
double floatingPoint = 12345.6789;

// Decimal format (with leading zeros)
Console.WriteLine(number.ToString("D10"));

//Fixed-point format (2 decimal places)
Console.WriteLine(floatingPoint.ToString("F2"));

//Currency format
Console.WriteLine(floatingPoint.ToString("C"));

//Percentage format (multiples by 100 and add a '%' sign)
double percentage = 0.1234;
Console.WriteLine(percentage.ToString("P"));

// Exponential format
Console.WriteLine(floatingPoint.ToString("E"));

// General format
Console.WriteLine(floatingPoint.ToString("G"));

Console.WriteLine("===================================\n");

double floatNumber = 12345.6789;
// Custom format with two decimal places
Console.WriteLine(floatNumber.ToString("0.00"));

// Custom format with commas for thousand separator
Console.WriteLine(floatNumber.ToString("#,##0"));

//Custom format with leading zeros
Console.WriteLine(floatNumber.ToString("00000"));

// Custom format with thousand separator and two decimals places
Console.WriteLine(floatNumber.ToString("#, ##0.00"));


