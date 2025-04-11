using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class PrintMultiplicationTableOfNumber
    {
        static void Main(string[] args)
        {
            int n, product;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                product = n * i;
                Console.WriteLine($"{n} * {i} = {product}");
            }
        }
    }
}
