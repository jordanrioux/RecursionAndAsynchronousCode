namespace Recursion.CLI;

public static class FibonacciDemo
{
    public static int FibonacciIterative(int number)
    {
        if (number == 0)
            return 0;
        
        var firstNumber = 0;
        var secondNumber = 1;
        for (var i = 2; i <= number; i++)
        {
            var nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
        return secondNumber;
    }
    
    // FibonacciRecursive(3) = FibonacciRecursive(2) + FibonacciRecursive(1)
    //      FibonacciRecursive(2) = 1 + 0
    //      FibonacciRecursive(1) = 1
    public static int FibonacciRecursive(int number)
    {
        // 1. Condition de fin (quand quitter la recursion)
        if (number is 0 or 1) return number;
        
        // 3. Recursion (etapes)
        return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
    }
}