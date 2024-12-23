// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Files




const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream


// TODO: Determine if a file exists

if (File.Exists(filename))
{
    File.Delete(filename);
}
else
{
    using StreamWriter sw = File.CreateText("local-" + DateTimeOffset.Now.ToUnixTimeSeconds() + "-" + filename);
    sw.WriteLine("This is a test file");
    sw.WriteLine("This is the second line");
}

System.Console.WriteLine("File created or not: "+ File.Exists(filename));
