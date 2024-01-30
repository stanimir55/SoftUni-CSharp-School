string[] n = Console.ReadLine().Split().ToArray();

int countRotations = int.Parse(Console.ReadLine());

for (int i = 1; i <= countRotations; i++)
{
    string temp = n[0];
    for (int k = 0; k < n.Length - 1; k++)
    {
        n[k] = n[k + 1];
    }
    n[n.Length - 1] = temp;
}

Console.WriteLine(string.Join(" ", n));
