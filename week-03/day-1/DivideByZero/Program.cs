﻿using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            float divisor = int.Parse(Console.ReadLine());
            

            try
            {
                float result = 10 / divisor;
                Console.WriteLine(result);

            }
            catch (Exception)
            {
                Console.WriteLine("false");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
// create a function that takes a number
// divides ten with it,
// and prints the result.
// it should print "fail" if the parameter is 0