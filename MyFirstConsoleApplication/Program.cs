using System;

string name = "Corey Moses"; // Variable containing my name
string location = "Rexburg, Idaho"; // Variable containing my location
Console.WriteLine("My name is " + name + "\nI am from " + location); // String Interpolation

DateTime currentDate = DateTime.Now; // Get the time and date now
Console.WriteLine(currentDate.ToShortDateString()); // Remove the time

DateTime todaysDate = DateTime.Today;           // Get today's date
DateTime christmasThisYear = new DateTime(currentDate.Year, 12, 25); // Christmas date for this year

// Calculate the difference in days
int daysUntilChristmas = (christmasThisYear - currentDate).Days;

Console.WriteLine($"There are {daysUntilChristmas} days until Christmas this year."); // A different method of String Interpolation


double width, height, woodLength, glassArea;
string widthString, heightString;

Console.Write("Please enter the width (in metres): ");
widthString = Console.ReadLine();
width = double.Parse(widthString);

Console.Write("Please enter the height (in metres): ");
heightString = Console.ReadLine();
height = double.Parse(heightString);

woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);

Console.WriteLine("The length of the wood is " + woodLength + " feet");
Console.WriteLine("The area of the glass is " + glassArea + " square metres");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
