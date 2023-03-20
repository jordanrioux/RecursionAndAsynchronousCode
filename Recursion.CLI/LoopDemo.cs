namespace Recursion.CLI;

public static class LoopDemo
{
    public static void PrintList(IEnumerable<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    
    public static void PrintListRecursive(IList<string> list)
    {
        PrintListRecursiveHelper(list, 0);
    }
    
    private static void PrintListRecursiveHelper(IList<string> list, int index)
    {
        if (index >= list.Count) return;

        Console.WriteLine(list[index]);
        PrintListRecursiveHelper(list, index + 1);
    }
}