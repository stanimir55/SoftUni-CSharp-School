int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());

int counter = 0; 

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int k = i + 1; k < numbers.Length; k++)
    {
        if (numbers[i] + numbers[k] == n)
        {
            //Console.WriteLine($"{numbers[i]} {numbers[k]}");
            Console.WriteLine(string.Join(" ", numbers[i], numbers[k]));
        }
    }
}

