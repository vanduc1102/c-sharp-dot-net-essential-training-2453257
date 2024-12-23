using System.IO;


class Program
{
    static void Main()
    {




        var currentDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent;

        System.Console.WriteLine($"Current Directory: {currentDir}");

        var DirPath = currentDir + "/Challenge/FileCollection";


        List<long> docs = new();
        List<long> excels = new();
        List<long> powerPoints = new();

        try
        {
            var files = Directory.GetFiles(DirPath);
            foreach (var file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Name.EndsWith(".docx"))
                {
                    docs.Add(fi.Length);
                }

                if (fi.Name.EndsWith(".xlsx"))
                {
                    excels.Add(fi.Length);
                }

                if (fi.Name.EndsWith(".pptx"))
                {
                    powerPoints.Add(fi.Length);
                }
            }

            System.Console.WriteLine("~~~~ Results ~~~~");
            System.Console.WriteLine($"Total Files: {docs.Count + excels.Count + powerPoints.Count}");
            System.Console.WriteLine($"Excel Count: {excels.Count}");
            System.Console.WriteLine($"Word Count: {docs.Count}");
            System.Console.WriteLine($"PowerPoint Count: {powerPoints.Count}");
            System.Console.WriteLine("----");
            System.Console.WriteLine($"Total Size: {(excels.Sum() + docs.Sum() + powerPoints.Sum()).ToString("N0")}");
            System.Console.WriteLine($"Excel Size: {excels.Sum().ToString("N0")}");
            System.Console.WriteLine($"Word Size: {docs.Sum().ToString("N0")}");
            System.Console.WriteLine($"PowerPoint Size: {powerPoints.Sum().ToString("N0")}");
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Directory not found {ex.Message}");
        }


    }
}