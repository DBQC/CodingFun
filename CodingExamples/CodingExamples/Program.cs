using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\\UploadedDocs\\");
            Console.WriteLine(ReferenceEquals(@"\\UploadedDocs\\", "\\\\UploadedDocs\\\\"));
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
    public static class StringExtentions
    {
        public static string CombineWithSeperator(this string string1, string string2, char seperator)
        {
            return string1 + seperator + string2;
        }
    }
        
}
    