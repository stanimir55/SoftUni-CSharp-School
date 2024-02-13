﻿using System.Collections.Generic;

List<int> firstList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> secondList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();
int interrations = Math.Max(firstList.Count, secondList.Count);

for (int i = 0; i < interrations; i++)
{
    if (i < firstList.Count)
    {
        result.Add(firstList[i]);
    }
    if (i < secondList.Count)
    {
        result.Add(secondList[i]);
    }
}

Console.WriteLine(string.Join(" ", result));