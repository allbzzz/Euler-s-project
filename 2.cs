using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Each new term in the Fibonacci sequence is generated by adding the previous two terms.
 * By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
 * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
 * find the sum of the even-valued terms.
*/

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            const int MaxNumber = 4_000_000;
            Console.WriteLine(SumOfEvenFibonacciNumbers(MaxNumber));
        }
        static int SumOfEvenFibonacciNumbers(int maxNum)
        {
            int sumNumbers = 0;
            int n1 = 1;
            int n2 = 2;
            while(n1 < maxNum)
            {
                if(n1 % 2 == 0)
                {
                    sumNumbers += n1;
                }
                int nextNum = n1 + n2;
                n1 = n2;
                n2 = nextNum;
            }
            return sumNumbers;
        }                 
    }
}