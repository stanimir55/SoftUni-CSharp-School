List<int> values = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
int rackCapacity = int.Parse(Console.ReadLine());

Stack<int> clothes = new Stack<int>(values);

int currentRackCapacity = 0;
int box = 1;

while (clothes.Count > 0)
{
    int currentClothe = clothes.Pop();

    if (currentClothe + currentRackCapacity <= rackCapacity)
    {
        currentRackCapacity += currentClothe;
    }
    else
    {
        currentRackCapacity = currentClothe;
        box++;
    }
}

Console.WriteLine(box);