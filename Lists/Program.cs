﻿using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(28);
            numbers.Add(33);

            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>()
            {
                1, 6, 7, 10, 14
            };

            Console.WriteLine(numbers2.Count);

            numbers2.Add(55);
            Console.WriteLine(numbers2.Count);

            numbers2.Clear();
            Console.WriteLine(numbers2.Count);

            List<string> countries = new List<string>()
            {
                "España", "Italia", "Argentina"
            };
            Console.WriteLine(countries.Count);
        }
    }
}