﻿using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> result = new List<int>();

        foreach (var item in numbers)
        {
            if (item >= 0)
            {
                result.Add(item);
            }
        }

        result.Reverse();

        if (result.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", result));
        }
    }
}