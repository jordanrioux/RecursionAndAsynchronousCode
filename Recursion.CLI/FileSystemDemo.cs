namespace Recursion.CLI;

public static class FileSystemDemo
{
    public static void PrintDirectoryTree(string rootDirectory)
    {
        PrintDirectoryTree(rootDirectory, 1);
    }

    private static void PrintDirectoryTree(string rootDirectory, int depth)
    {
        var paddedString = " ".PadLeft(depth * 2);
        foreach (var file in Directory.GetFiles(rootDirectory))
        {
            Console.WriteLine($"{paddedString}{Path.GetFileName(file)}");
        }
        
        foreach (var directory in Directory.GetDirectories(rootDirectory))
        {
            Console.WriteLine($"{paddedString}- {Path.GetFileName(directory)}");
            PrintDirectoryTree(directory, depth + 1);
        }
    }
    
    private static void Example(string rootDirectory)
    {
        foreach (var path in Directory.GetFileSystemEntries(rootDirectory))
        {
            if (File.Exists(path))
            {
                Console.WriteLine(Path.GetFileName(path));    
            }
            else if (Directory.Exists(path))
            {
                Console.WriteLine(Path.GetFileName(path));
                PrintDirectoryTree(path);
            }
        }
    }
}