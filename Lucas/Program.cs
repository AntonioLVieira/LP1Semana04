﻿using System;

namespace Lucas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Lucas(n));
        }
        private static int Lucas(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Lucas(n-1) + Lucas(n-2); 
            }
            
        }
    }
}
