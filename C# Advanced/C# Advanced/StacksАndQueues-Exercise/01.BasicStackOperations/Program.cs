List<int> operations = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
Stack<int> stack = new Stack<int>();

int elementsToPush = operations[0];
int elementsToPop = operations[1];
int elementToLookUp = operations[2];

for (int i = 0; i < elementsToPush; i++)
{
    stack.Push(numbers[i]);
}

while (stack.Any() && elementsToPop > 0)
{
    stack.Pop();
    elementsToPop--;
}

if (!stack.Any())
{
    Console.WriteLine("0");
}
else if (stack.Contains(elementToLookUp))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}