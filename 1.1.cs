using System;
using System.Linq;


public class Tutorial
{
    public static void Main()
    {
        const int maxNumber = 1000;
        int sum = SumOfNumbers(maxNumber);
        Console.WriteLine(sum);
    }
    
    static int SumOfNumbers(int n)
    {
        int sum = Enumerable.Range(1, n - 1).Where(num => num % 3 == 0 || num % 5 == 0).Sum();
        return sum;
        
    }
}