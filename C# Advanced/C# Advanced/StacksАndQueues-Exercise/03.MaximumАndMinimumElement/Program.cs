﻿int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    int[] arguments = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    int command = arguments[0];

    if (command == 1)
    {
        stack.Push(arguments[1]);
    }
    else if (command == 2 && stack.Any())
    {
        stack.Pop();
    }
    else if (command == 3 && stack.Any())
    {
        Console.WriteLine(stack.Max());
    }
    else if (command == 4 && stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
}

Console.WriteLine(string.Join(", ", stack));