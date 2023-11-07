int n = int.Parse(Console.ReadLine());
int maxNum = int.MinValue;
int sum = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    if (num > maxNum)
    {
        maxNum = num;
    }
}
int sumOutMax = sum - maxNum;

if (maxNum == sumOutMax)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = "  + maxNum);
}
else
{
    int diff = Math.Abs(maxNum - sumOutMax);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);
}