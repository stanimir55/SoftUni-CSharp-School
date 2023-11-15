﻿List<int> first = ReadIntList();

List<int> second = ReadIntList();

List<int> result = new List<int>();

int interrations = Math.Max(first.Count, second.Count);

for (int i = 0; i < interrations; i++)
{
    if (i < first.Count)
    {
        result.Add(first[i]);
    }

    if (i < second.Count)
    {
        result.Add(second[i]);
    }
}

Console.WriteLine(string.Join(" ", result));

static List<int> ReadIntList()
{
    return Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();
}