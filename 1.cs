using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5,
 * we get and The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            const int MaxNumber = 1000;
            Console.WriteLine(SumOfNumbers(MaxNumber));
        }
        static int SumOfNumbers(int maxNum)
        {
            int sumNumbers = 0;
            for (int i = 0; i < maxNum; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumNumbers += i;
                }
            }
            return sumNumbers;
        }                 
    }
}
