// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for formatting string content


float f1 = 123.4f;
int i1 = 2000;

// TODO: Spacing and Alignment: Indexes

System.Console.WriteLine("The value of f1 is {0, 7} and i1 is {1, 11}", f1, i1);
// TODO: Spacing and Alignment: Interpolation

System.Console.WriteLine($"The value of f1 is {f1, 11} and i1 is {i1, 13}");
