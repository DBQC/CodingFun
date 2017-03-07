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

        public string CombineWithSeperator(this string[] stringarray,char seperator)
        {
            string result= "";
            foreach (string item in stringarray)
            {
                result += item + seperator;
            }
            return result.TrimEnd(seperator);
            
        }
    }

    
}
    