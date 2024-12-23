// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string

System.Console.WriteLine($"The length of str1 is {str1.Length}");

// TODO: Access individual characters

System.Console.WriteLine($"The first character of str1 is {str1[0]}");

// TODO: Iterate over a string like any other sequence of values

System.Console.WriteLine("Iterating over str1: " , "aa".Equals("aa"));
System.Console.WriteLine("Iterating over str1: ");
foreach (char c in str1)
{
    System.Console.Write(c);
}
System.Console.WriteLine();

// TODO: String Concatenation
string outstr;

System.Console.WriteLine("Concatenating str1 and str2: {0}", str1 + str2);

// TODO: Joining strings together with Join


// TODO: String Comparison

// Equals just returns a regular Boolean
// bool isEqual = str2.Equals(str3);
// Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order


// TODO: Replacing content
