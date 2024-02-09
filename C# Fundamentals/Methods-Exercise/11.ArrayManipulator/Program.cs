int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string commands;
while ((commands = Console.ReadLine()) != "end")
{
    string[] arguments = commands.Split();

    switch (arguments[0])
    {
        case "exchange":
            int index = int.Parse(arguments[1]);
            numbers = Exchange(numbers, index);
            break;
        case "max":
            string maxType = arguments[1];
            PrintMaxNumber(numbers, maxType);
            break;
        case "min":
            string minType = arguments[1];
            PrintMinNumber(numbers, minType);
            break;
        case "first":
            int firstLenght = int.Parse(arguments[1]);
            string firstType = arguments[2];
            PrintFirstElements(numbers, firstLenght, firstType);
            break;
        case "last":
            int lastLenght = int.Parse(arguments[1]);
            string lastType = arguments[2];
            PrintLastElements(numbers, lastLenght, lastType);
            break;
    }
}

Console.WriteLine($"[{string.Join(", ", numbers)}]");

static int[] Exchange(int[] numbers, int index)
{
    if (ChekForOutOfBound(numbers, index))
    {
        Console.WriteLine("Invalid index");
        return numbers;
    }

    int[] changedArray = new int[numbers.Length];
    int changedArrayIndex = 0;

    for (int i = index + 1; i < numbers.Length; i++)
    {
        changedArray[changedArrayIndex] = numbers[i];
        changedArrayIndex++;
    }

    for (int i = 0; i <= index; i++)
    {
        changedArray[changedArrayIndex] = numbers[i];
        changedArrayIndex++;
    }

    return changedArray;
}

static void PrintMaxNumber(int[] numbers, string maxType)
{
    int maxIndex = -1;
    int maxNumber = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (IsOddOrEven(numbers[i], maxType))
        {
            if (numbers[i] >= maxNumber)
            {
                maxNumber = numbers[i];
                maxIndex = i;
            }
        }
    }

    PrintIndex(maxIndex);
}

static void PrintMinNumber(int[] numbers, string minType)
{
    int minIndex = -1;
    int minNumber = int.MaxValue;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (IsOddOrEven(numbers[i], minType))
        {
            if (numbers[i] <= minNumber)
            {
                minNumber = numbers[i];
                minIndex = i;
            }
        }
    }

    PrintIndex(minIndex);
}

static void PrintFirstElements(int[] numbers, int count, string type)
{
    if (IsInvalid(numbers, count))
    {
        Console.WriteLine("Invalid count");
        return;
    }

    string firstElements = "";
    int elementCount = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (IsOddOrEven(numbers[i], type))
        {
            firstElements += $"{numbers[i]}, ";
            elementCount++;

            if (elementCount >= count)
            {
                break;
            }
        }
    }

    Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
}

static void PrintLastElements(int[] numbers, int count, string type)
{
    if (IsInvalid(numbers, count))
    {
        Console.WriteLine("Invalid count");
        return;
    }

    string lastElements = "";
    int elementCount = 0;

    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        if (IsOddOrEven(numbers[i], type))
        {
            lastElements = $"{numbers[i]}, " + lastElements;
            elementCount++;

            if (elementCount >= count)
            {
                break;
            }
        }
    }

    Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
}

static bool ChekForOutOfBound(int[] numbers, int index)
{
    return index < 0 || index >= numbers.Length;
}

static void PrintIndex(int maxIndex)
{
    if (maxIndex != -1)
    {
        Console.WriteLine(maxIndex);
    }
    else
    {
        Console.WriteLine("No matches");
    }
}

static bool IsOddOrEven(int numbers, string maxtype)
{
    return (maxtype == "odd" && numbers % 2 == 1) || (maxtype == "even" && numbers % 2 == 0);
}

static bool IsInvalid(int[] numbers, int count)
{
    return count > numbers.Length;
}