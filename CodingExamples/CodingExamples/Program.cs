﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(args[0]);

            var result = true;

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }                
            }             
            Console.WriteLine(result);
        }
    }

    
}
    