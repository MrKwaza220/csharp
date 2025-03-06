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

//int number = 12345;
//double floatingPoint = 12345.6789;

//// Decimal format (with leading zeros)
//Console.WriteLine(number.ToString("D10"));

////Fixed-point format (2 decimal places)
//Console.WriteLine(floatingPoint.ToString("F2"));

////Currency format
//Console.WriteLine(floatingPoint.ToString("C"));

////Percentage format (multiples by 100 and add a '%' sign)
//double percentage = 0.1234;
//Console.WriteLine(percentage.ToString("P"));

//// Exponential format
//Console.WriteLine(floatingPoint.ToString("E"));

//// General format
//Console.WriteLine(floatingPoint.ToString("G"));

//Console.WriteLine("===================================\n");

//double floatNumber = 12345.6789;
//// Custom format with two decimal places
//Console.WriteLine(floatNumber.ToString("0.00"));

//// Custom format with commas for thousand separator
//Console.WriteLine(floatNumber.ToString("#,##0"));

////Custom format with leading zeros
//Console.WriteLine(floatNumber.ToString("00000"));

//// Custom format with thousand separator and two decimals places
//Console.WriteLine(floatNumber.ToString("#, ##0.00"));

//Console.WriteLine("Formatting numerical data");
//int[] quarters = {1, 2, 3, 4};
//int[] sales = { 100000, 150000, 200000, 225000 };
//double[] intlMixPct = { .386, .413, .421, .457 };
//int val1 = 1234;
//decimal val2 = 1234.5678m;

// General format is {index[, alignment]:[format]}
// Common types are N (number), G (General), F(Fixed-point),
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)

//Console.WriteLine($"Using val1: {val1:D}, {val1:N}, {val1:F}, {val1:G}");
//Console.WriteLine($"Using val2: {val2:E}, {val2:N}, {val2:F}, {val2:G}");

//Add a number after the format to specify precision
//Console.WriteLine($"Using val1: {val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}");

//Console.WriteLine("Sales by Quarter:");
//Console.WriteLine($"{quarters[0],12} {quarters[1],12} {quarters[2],12} {quarters[3],12}");
//Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");
//Console.WriteLine("International Sales");
//Console.WriteLine($"{intlMixPct[0],12:P0} {intlMixPct[1],12:P0} {intlMixPct[2],12:P1} {intlMixPct[3],12:P2}");


//Use DateTime.Now property to get the current date and time
//DateTime now = DateTime.Now;
//Console.WriteLine($"Today's Date and Time: {now}");

// DateTime.Today gets just the current date with time set to 12:00:00 AM
//DateTime today = DateTime.Today;
//Console.WriteLine($"Today's Date and Time set to Midnight: {today}");

// DateOnly and TimeOnly represent just dates and times
//DateOnly date = DateOnly.FromDateTime(DateTime.Now);
//TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);
//Console.WriteLine($"Date Only: {date}");
//Console.WriteLine($"Time Only: {time}");

//Dates have properties that can be inspected
//Console.WriteLine(today.DayOfWeek);
//Console.WriteLine(today.DayOfYear);

// Dates also have methods to change their values
//now = now.AddHours(5);
//now = now.AddDays(9);
//now = now.AddMonths(1);
//Console.WriteLine(now);

//The Timespan class represent a duration of time
DateTime AprilFool = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFool - NewYears;
Console.WriteLine("Timespan: " + interval);
//Console.WriteLine("=============Formatting dates and Times==============");

////Define a date
//DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

//// small letter "d" for short date: mm/dd/yyyy (or dd/mm depending on locale)
//Console.WriteLine($"Short Date: {AprFools:d}");

//// Capital letter "D" for full date: mm/dd/yyyy (or dd/mm depending on locale)
//Console.WriteLine($"Full Date: {AprFools:D}");

//// "f" full date and short time
//Console.WriteLine($"Full Date and Short Time: {AprFools:f}");

//// "F" full date and Long time
//Console.WriteLine($"Full date and Long time: {AprFools:F}");

//// "g" general date and time
//Console.WriteLine($"General date and time: {AprFools:g}");

//// "G" general date and time
//Console.WriteLine($"General date and time: {AprFools:G}");

////Defining custom date and time formats
//Console.WriteLine($"{AprFools:dddd, MMMM, d yyyy}");
//Console.WriteLine($"{AprFools:ddd, h:mm:ss, tt}");
//Console.WriteLine($"{AprFools: MMMM, d yyyy}");

Console.WriteLine("<----Collection of various date string formats to attemp parsing---->");
//Collection of various date string formats to attemp parsing
string[] sampleDateTimes =
{
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes)
{
    DateTime result;

    // Use the static class function TryParse to try parsing the dates

    if (DateTime.TryParse(datestr, out result))
    {
        Console.WriteLine($"{datestr,-25} gets parsed as:  {result}");
    }
    else
    {
        Console.WriteLine($"Could not parse '{datestr}'.");
    }
}





