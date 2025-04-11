using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindXToThePowerY
    {
        static void Main(string[] args)
        {
            int x, y, xPowerY = 1 ;
            Console.Write("Enter x value: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value: ");
            y = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= y; i++)
            {
                xPowerY *= x;
            }

            Console.WriteLine($"{x} to the power {y} is {xPowerY}");
        }
    }
}
