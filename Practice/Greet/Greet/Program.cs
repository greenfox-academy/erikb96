﻿using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Greet(al);
            
            Console.ReadLine();
        }
        static void Greet(string al)
        {
            Console.WriteLine("Greetings dear," + al + "!" );
        }
        // - Create a string variable named `al` and assign the value `Greenfox` to it
        // - Create a function called `greet` that greets it's input parameter
        //     - Greeting is printing e.g. `Greetings dear, Greenfox`
        // - Greet `al`
    }
}