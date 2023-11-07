int startNum = int.Parse(Console.ReadLine());
int endNum = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int count = 0;
bool isFound = false;

for (int i = startNum; i <= endNum; i++)
{
    for (int j = startNum; j <= endNum; j++)
    {
        count++;

        int sum = i + j;

        if (sum == magicNum)
        {
            Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
            isFound = true;
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}

if (!isFound)
{
    Console.WriteLine($"{count} combinations - neither equals {magicNum}");
}