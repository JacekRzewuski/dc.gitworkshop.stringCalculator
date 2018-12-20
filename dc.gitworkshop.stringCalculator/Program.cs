﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc.gitworkshop.stringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // for empty input just return 0
            Test(expected: "0", actual: StringCalculator.Compute(""));

            // sum numbers 1 and 2
            Test(expected: "3", actual: StringCalculator.Compute("1,2"));

            // sum numbers 1 and 2 and 3
            Test(expected: "6", actual: StringCalculator.Compute("1,2,3"));

            // allow \n to be a number delimeter
            Test(expected: "3", actual: StringCalculator.Compute("1\n2"));

            // negative numbers are not allowed
            Test(expected: "negatives not allowed", actual: StringCalculator.Compute("-1"));
            Test(expected: "negatives not allowed", actual: StringCalculator.Compute("1,-1"));
            
            // ignore numbers greater than 1000 when summing
            Test(expected: "3", actual: StringCalculator.Compute("1000,1,2"));
            Test(expected: "1003", actual: StringCalculator.Compute("500,1,2,500"));

            // return error on numbers greter than 1500
            Test(expected: "numbers greater than 1500 not allowed", actual: StringCalculator.Compute("2000,1,2"));

            Console.WriteLine("Press [enter] to exit");
            Console.ReadLine();
        }

        private static void Test(string expected, string actual)
        {
            if (expected == actual)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Test did not pass. Expected:{expected} Actual:{actual}");
            }
        }
    }
}
