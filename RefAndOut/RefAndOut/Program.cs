using NLog;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            var input = Console.ReadLine();
            /*
            int number;

            try
            {
                number = int.Parse(input);
                Console.WriteLine($"Number entered {number}");
            }

            catch(FormatException)
            {
                Console.WriteLine("Invalid Input");
            }
            */
            int number;
            if(int.TryParse(input,out number))
            {
                Console.WriteLine($"Number entered: {number}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            int.TryParse(input, out number);

            var dict = new Dictionary<string, int>();

            if(dict.TryGetValue("nick", out var value))
            {
                // Some work with value
            }

            int x = 40;
            ChangeMyInt(ref x);
            Console.WriteLine(x);

            ILogger logger = LogManager.GetCurrentClassLogger();

            logger.Debug("logger created successfully");

            try
            {
                int.Parse("asd");
            }

            catch(FormatException ex)
            {
                logger.Error(ex);
            }

            //var logline = "";
            //var match = Regex.Match(logline, @"")

            Console.ReadLine(); // there just to holder to see console
        }

        public static void ChangeMyIntDoesntWork(int number)
        {
            number = 10;
        }
        
        public static void ChangeMyInt(ref int number)
        {
            number = 10;
        }
        /*
        
        In order to compile unsafe code, we need to enable it on a project level (csproj file).
        Pointers are like ref variables, but lesss abstracted, we can see the exact memory locaion of the value.

        Avoid using pointers in C# unless dealing with unmanaged API's (e.g. windows API)

        public static unsafe void ChangeMyIntTwo(int* number)
        {
            *number = 5;
        }
        */

    }
}
