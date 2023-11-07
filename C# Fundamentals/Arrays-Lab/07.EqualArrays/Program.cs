using System;

int[] numbersOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] numbersTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool areIdentical = true;

for (int i = 0; i < numbersOne.Length; i++)
{
    if(numbersOne[i] != numbersTwo[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        areIdentical = false;
        break;
    }

    sum += numbersOne[i];
}

if (areIdentical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}
