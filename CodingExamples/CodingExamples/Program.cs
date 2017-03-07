using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var DidItWork = int.TryParse(args[0],out number);

            bool result = true;

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
    