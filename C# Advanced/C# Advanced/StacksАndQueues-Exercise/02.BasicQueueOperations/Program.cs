List<int> operations = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

Queue<int> queue = new Queue<int>();

int elementsToEnqueue = operations[0];
int elementsToDequeue = operations[1];
int elementToLookUp = operations[2];

for (int i = 0; i < elementsToEnqueue; i++)
{
    queue.Enqueue(numbers[i]);
}

while (queue.Count > 0 && elementsToDequeue > 0)
{
    queue.Dequeue();
    elementsToDequeue--;
}

if (!queue.Any())
{
    Console.WriteLine(0);
}
else if (queue.Contains(elementToLookUp))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}