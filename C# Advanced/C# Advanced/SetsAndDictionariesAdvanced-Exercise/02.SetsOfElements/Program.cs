int[] lenghtOfSets = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = lenghtOfSets[0];
int m = lenghtOfSets[1];

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    firstSet.Add(currentNumber);
}

for (int i = 0; i < m; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    secondSet.Add(currentNumber);
}

Console.WriteLine(string.Join(" ", firstSet.Intersect(secondSet)));