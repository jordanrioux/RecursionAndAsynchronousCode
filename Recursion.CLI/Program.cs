using Recursion.CLI;

var names = new List<string>
{
    "Jordan Rioux",
    "David Tucker",
    "Alexandre Vovan",
    "Christopher Masse",
    "Jean-Philippe Hebert",
    "Hugues Masse (popa de Christo)",
    "Richard Farley"
};

Console.WriteLine("--- PRINT LIST (iterative) ---");
LoopDemo.PrintList(names);
Console.WriteLine("");

Console.WriteLine("--- PRINT LIST (recursive) ---");
LoopDemo.PrintListRecursive(names);
Console.WriteLine("");




Console.WriteLine("--- FIBONACCI (iterative) ---");
var numIterative = FibonacciDemo.FibonacciIterative(5);
Console.WriteLine($"Iterative: {numIterative}");
Console.WriteLine("");

Console.WriteLine("--- FIBONACCI (recursive) ---");
var numRecursive = FibonacciDemo.FibonacciRecursive(5);
Console.WriteLine($"Recursive: {numRecursive}");
Console.WriteLine("");


Console.WriteLine("--- File System ---");
Console.WriteLine("");
FileSystemDemo.PrintDirectoryTree("/Users/jordy/Desktop");
