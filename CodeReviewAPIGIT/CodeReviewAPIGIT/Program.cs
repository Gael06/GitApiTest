﻿using System;

namespace CodeReviewAPIGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            var firstVar = string.Format("{0} commit infos", Console.ReadLine());
            Console.ReadLine();
            firstVar += "removed and added line test";
        }
    }
}
