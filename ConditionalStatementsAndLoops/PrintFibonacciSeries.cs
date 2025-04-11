using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class PrintFibonacciSeries
    {
        static void Main(string[] args)
        {
            int n, firstNum = 0, secondNum = 1, nextNum;
            Console.Write("Enter total numbers in fibonacci series: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{firstNum}, {secondNum}, ");

            for (int i = 3; i <= n; i++)
            {
                nextNum = firstNum + secondNum;
                Console.Write($"{nextNum}, ");
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    }
}
