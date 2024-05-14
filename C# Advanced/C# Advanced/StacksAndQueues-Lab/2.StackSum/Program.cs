int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < numbers.Length; i++)
{
    stack.Push(numbers[i]);
}

string commands;
while ((commands = Console.ReadLine().ToLower()) != "end")
{
    string[] arguments = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];

    switch (command)
    {
        case "add":
            int firstNumber = int.Parse(arguments[1]);
            int secondNumber = int.Parse(arguments[2]);

            stack.Push(firstNumber);
            stack.Push(secondNumber);
            break;
        case "remove":
            int number = int.Parse(arguments[1]);

            if (stack.Count <= number)
            {
                continue;
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    stack.Pop();
                }
            }
            break;
    }
}

Console.WriteLine($"Sum: {stack.Sum()}");