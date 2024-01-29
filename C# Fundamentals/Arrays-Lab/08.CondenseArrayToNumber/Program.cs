int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] nums = new int[number.Length - 1];

if (number.Length == 1)
{
    Console.WriteLine(number[0]);
    return;
}

for (int i = 0; i < number.Length; i++)
{
    for (int k = 0; k < nums.Length - i; k++)
    {
        nums[k] = number[k] + number[k + 1];
    }

    number = nums;
}

Console.WriteLine(nums[0]);