﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class RightTraingleRepeatNumberPatternDesc
    {
        static void Main(string[] args)
        {
            int n, i, j;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = n; i >= 1; i--)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
